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

ClibIHM::ClibIHM(int nbChamps, byte* dataImage1, int strideImage1, const byte* dataImage2, const int strideImage2, int nbLig, int nbCol, bool imageIn) {
	this->nbDataImg = nbChamps;
	this->dataFromImg.resize(nbChamps);
	this->imgPt = new CImageCouleur(nbLig, nbCol);
	CImageCouleur groundTruth(nbLig, nbCol);
	CImageCouleur out(nbLig, nbCol);

	// on remplit les pixels 

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
	}

	CImageNdg image = this->imgPt->plan(3); //TODO LABE remettre
	CImageNdg groundTruthNdg = groundTruth.plan(3); //TODO LABE remettre
	float score = 0.0;

	// TODO LABE 
	// Faire le traitement sur l'image et ressortir le score et l'image traitée.
	CImageNdg traite; //TODO LABE remettre
	if (imageIn) traite = Image_In(image, groundTruthNdg, score/*, se*/);


	//this->dataFromImg[0] = score;
	out = CImageCouleur(traite); //TODO LABE remettre

	pixPtr = (byte*)dataImage1;
	for (int y = 0; y < nbLig; y++)
	{
		for (int x = 0; x < nbCol; x++)
		{
			pixPtr[3 * x + 2] = out(y, x)[0];
			pixPtr[3 * x + 1] = out(y, x)[1];
			pixPtr[3 * x] = out(y, x)[2];
		}
		pixPtr += strideImage1; // largeur une seule ligne gestion multiple 32 bits
	}
}


ClibIHM::~ClibIHM() {

	if (imgPt)
		(*this->imgPt).~CImageCouleur();
	this->dataFromImg.clear();
}

CImageNdg ClibIHM::Image_In(const CImageNdg image,const CImageNdg imageGroundTruth, float score)/*, ELEMENT_STRUCTURANT se*/
{
	CImageNdg imageTraitee = CImageNdg(image);
	CImageNdg blanche = CImageNdg(image.lireHauteur(), image.lireLargeur(), 255);
	// Traitement sur l'image
	for (int i = 0; i < image.lireHauteur()* image.lireLargeur(); i++) {
		imageTraitee(i) = blanche(i) - image(i);
		if (imageTraitee(i)< 0) imageTraitee(i) = 0;
	}
	//imageTraitee = blanche.operator-(image); // verifier
	//imageTraitee = whiteTopHatavecSE(imageTraitee, se, 30);
	//imageTraitee = seuillageOtsu(imageTraitee);
	//imageTraitee = erosionImageavecSE(imageTraitee, se);
	//imageTraitee = erosionImageavecSE(imageTraitee, se);
	//imageTraitee = dilatationImageavecSE(imageTraitee, se);
	//imageTraitee = recuperation_blobs_communs(veriteTerrain, imageTraitee);

	//// Calcul du score IOU
	//score = IOU_score(imageTraitee, imageGroundTruth);
	return imageTraitee;
}
//
//float Image_Sc(char** imagePaths, char** veriteTerrainPaths, ELEMENT_STRUCTURANT se, int nb_it)
//{
//	int compteur = 0;
//	float ajout_score = 0.0;
//	float* tableau_IOU = malloc(sizeof(float) * nb_it);
//	float* tableau_Moy = malloc(sizeof(float) * nb_it);
//
//	IMAGE imageTraitee;
//	for (int i = 0; i < nb_it; i++)
//	{
//		// Charger l'image
//		IMAGE image = lectureImage(imagePaths[i]);
//		IMAGE veriteTerrain = lectureImage(veriteTerrainPaths[i]);
//
//		// Traitement sur l'image
//		imageTraitee = whiteTopHatavecSE(image, se, 30);
//		imageTraitee = seuillageOtsu(imageTraitee);
//		imageTraitee = erosionImageavecSE(imageTraitee, se);
//		imageTraitee = dilatationImageavecSE(imageTraitee, se);
//		//imageTraitee = recuperation_blobs_communs(veriteTerrain, imageTraitee);
//
//		// Calcul du score IOU
//		float IOU = IOU_score(imageTraitee, veriteTerrain);
//		tableau_IOU[i] = IOU;
//
//		// Accumulation des scores
//		ajout_score += IOU;
//		compteur++;
//
//		// Calcul de la moyenne et ajout au tableau
//		tableau_Moy[i] = ajout_score / compteur;
//	}
//
//	// Sauvegarde du tableau dans un fichier CSV
//	sauvegardeCSV(tableau_IOU, tableau_Moy, nb_it, "resultats.csv");
//
//	// Libération de la mémoire
//	free(tableau_IOU);
//	free(tableau_Moy);
//
//	return tableau_Moy[nb_it - 1];
//}