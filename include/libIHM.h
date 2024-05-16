#pragma once

#include "ImageClasse.h"
#include "ImageNdg.h"
#include "ImageCouleur.h"
#include "ImageDouble.h"

#include <windows.h>

class ClibIHM {

	///////////////////////////////////////
private:
	///////////////////////////////////////

	// data nécessaires à l'IHM donc fonction de l'application ciblée
	int						nbDataImg; // nb champs Texte de l'IHM
	std::vector<double>		dataFromImg; // champs Texte de l'IHM
	CImageCouleur* imgPt;       // 

	///////////////////////////////////////
public:
	///////////////////////////////////////

	// constructeurs
	_declspec(dllexport) ClibIHM(); // par défaut

	_declspec(dllexport) ClibIHM(int nbChamps, byte* dataImage1, int strideImage1,const byte* dataImage2,const int strideImage2, int nbLig, int nbCol, bool imageIn); // par image format bmp C#

	_declspec(dllexport) ~ClibIHM();

	_declspec(dllexport) CImageNdg Image_In(CImageNdg image, CImageNdg imageGroundTruth, float score);/*, ELEMENT_STRUCTURANT se*/

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

extern "C" _declspec(dllexport) ClibIHM * objetLibDataImg(int nbChamps, byte * dataImage1, int strideImage1, byte * dataImage2, int strideImage2, int nbLig, int nbCol, bool imageIn)
{
	ClibIHM* pImg = new ClibIHM(nbChamps, dataImage1, strideImage1, dataImage2, strideImage2, nbLig, nbCol, imageIn);
	return pImg;
}

extern "C" _declspec(dllexport) double valeurChamp(ClibIHM * pImg, int i)
{
	return pImg->lireChamp(i);
}
