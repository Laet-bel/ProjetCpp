#include <iostream>
#include <fstream>
#include <sstream>
#include <string>
#include <windows.h>
#include <cmath>
#include <vector>
#include <ctime>
#include <stack>

#include "libIHM.h"

ClibIHM::ClibIHM() {

	this->nbDataImg = 0;
	this->dataFromImg.clear();
	this->imgPt = NULL;
}

ClibIHM::ClibIHM(int nbChamps, byte* dataImage1, int strideImage1, const byte* dataImage2, const int strideImage2, int nbLig, int nbCol, const bool imageIn, char* typeSE, const int largeurSE, const int hauteurSE)
{
	// Récupération des données de l'image
	this->nbDataImg = nbChamps;
	this->dataFromImg.resize(nbChamps);
	this->imgPt = new CImageCouleur(nbLig, nbCol);

	// Création des images couleurs qui serviront pour le traitement
	CImageCouleur groundTruth(nbLig, nbCol);
	CImageCouleur out(nbLig, nbCol);

	// Récupération des données de l'image dans les images couleurs
	byte* pixPtr = (byte*)dataImage1;
	byte* pixPtr2 = (byte*)dataImage2;

	for (int y = 0; y < nbLig; y++)
	{
		for (int x = 0; x < nbCol; x++)
		{
			this->imgPt->operator()(y, x)[0] = pixPtr[3 * x + 2];
			this->imgPt->operator()(y, x)[1] = pixPtr[3 * x + 1];
			this->imgPt->operator()(y, x)[2] = pixPtr[3 * x];
			groundTruth.operator()(y, x)[0] = pixPtr2[3 * x + 2];
			groundTruth.operator()(y, x)[1] = pixPtr2[3 * x + 1];
			groundTruth.operator()(y, x)[2] = pixPtr2[3 * x];
		}
		pixPtr += strideImage1; // largeur une seule ligne gestion multiple 32 bits
		pixPtr2 += strideImage2; // largeur une seule ligne gestion multiple 32 bits
	}

	// Conversion des images couleurs en images ndg
	CImageNdg image = this->imgPt->plan(3);
	CImageNdg groundTruthNdg = groundTruth.plan(3);

	// Initialisation du score
	float score = 0.0;

	// Faire le traitement sur l'image et ressortir le score et l'image traitée.
	CImageNdg traitee;
	ElementStructurant se(typeSE, largeurSE, hauteurSE);
	if (imageIn) traitee = Image_In(image, groundTruthNdg, score, se);
	else traitee = Image_Sc(image, groundTruthNdg, score, se);

	this->dataFromImg[0] = score; // Récupération du scrore dans dataFromImg

	// Conversion de l'image traitée en image couleur qui sera l'image de sortie
	out = CImageCouleur(traitee);

	// Récupération des données de l'image traitée dans les données de l'image véritée en entrée
	pixPtr = (byte*)dataImage1;
	for (int y = 0; y < nbLig; y++)
	{
		for (int x = 0; x < nbCol; x++)
		{
			pixPtr[3 * x + 2] = out(y, x)[0];
			pixPtr[3 * x + 1] = out(y, x)[1];
			pixPtr[3 * x] = out(y, x)[2];
		}
		pixPtr += strideImage1;
	}
}

// Destructeur
ClibIHM::~ClibIHM() {

	if (imgPt)
		(*this->imgPt).~CImageCouleur();
	this->dataFromImg.clear();
}

// Méthode pour récupérer le score des image de type In
CImageNdg ClibIHM::Image_In(const CImageNdg& image, CImageNdg& imageGroundTruth, float& score, ElementStructurant& se)
{
	CImageNdg imageTraitee(image);

	// Traitement sur l'image
	imageTraitee = imageTraitee.transformation("complement");
	imageTraitee = imageTraitee.whiteTopHatavecSE(imageTraitee, se, 30);
	imageTraitee = imageTraitee.seuillage();
	imageTraitee = imageTraitee.erosionImageavecSE(imageTraitee, se);
	imageTraitee = imageTraitee.erosionImageavecSE(imageTraitee, se);
	imageTraitee = imageTraitee.dilatationImageavecSE(imageTraitee, se);
	imageTraitee = imageTraitee.dilatationImageavecSE(imageTraitee, se);

	// Calcul du score IOU
	score = imageTraitee.IOU_score(imageTraitee, imageGroundTruth);
	return imageTraitee;
}

// Méthode pour récupérer le score des image de type Sc
CImageNdg ClibIHM::Image_Sc(const CImageNdg& image, CImageNdg& imageGroundTruth, float& score, ElementStructurant& se)
{
	CImageNdg imageTraitee(image);

	// Traitement sur l'image
	imageTraitee = imageTraitee.whiteTopHatavecSE(imageTraitee, se, 30);
	imageTraitee = imageTraitee.seuillage();
	imageTraitee = imageTraitee.erosionImageavecSE(imageTraitee, se);
	imageTraitee = imageTraitee.dilatationImageavecSE(imageTraitee, se);

	// Calcul du score IOU
	score = imageTraitee.IOU_score(imageTraitee, imageGroundTruth);
	return imageTraitee;
}