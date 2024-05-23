#pragma once

#include "ImageNdg.h"
#include "ImageCouleur.h"
#include "ElementStructurant.h"

#include <windows.h>

class ClibIHM {

	///////////////////////////////////////
private:
	///////////////////////////////////////

	// data nécessaires à l'IHM donc fonction de l'application ciblée
	int						nbDataImg; // nb champs Texte de l'IHM
	std::vector<double>		dataFromImg; // champs Texte de l'IHM
	CImageCouleur* imgPt;       // 

private:
	//ElementStructurant se; // élément structurant

	///////////////////////////////////////
public:
	///////////////////////////////////////

	// constructeurs
	_declspec(dllexport) ClibIHM(); // par défaut

	_declspec(dllexport) ClibIHM(int nbChamps, byte* dataImage1, int strideImage1, const byte* dataImage2, const int strideImage2, int nbLig, int nbCol, const bool imageIn, char* typeSE, const int largeurSE, const int hauteurSE); // par image format bmp C#

	_declspec(dllexport) ~ClibIHM();

	_declspec(dllexport) CImageNdg Image_In(const CImageNdg& image,CImageNdg& imageGroundTruth, float& score, ElementStructurant& se);
	_declspec(dllexport) CImageNdg Image_Sc(const CImageNdg& image,CImageNdg& imageGroundTruth, float& score, ElementStructurant& se);

	// get et set 

	_declspec(dllexport) int lireNbChamps() const {
		return nbDataImg;
	}

	_declspec(dllexport) double lireChamp(int i) const {
		return dataFromImg.at(i);
	}

	_declspec(dllexport) CImageCouleur* imgData() const {
		return imgPt;
	}

};

extern "C" _declspec(dllexport) ClibIHM * objetLib()
{
	ClibIHM* pImg = new ClibIHM();
	return pImg;
}

extern "C" _declspec(dllexport) ClibIHM * objetLibDataImg(int nbChamps, byte * dataImage1, int strideImage1, byte * dataImage2, int strideImage2, int nbLig, int nbCol, bool imageIn, char* typeSE, int largeurSE, int hauteurSE)
{
	ClibIHM* pImg = new ClibIHM(nbChamps, dataImage1, strideImage1, dataImage2, strideImage2, nbLig, nbCol, imageIn, typeSE, largeurSE, hauteurSE);
	return pImg;
}

extern "C" _declspec(dllexport) double valeurChamp(ClibIHM * pImg, int i)
{
	return pImg->lireChamp(i);
}
