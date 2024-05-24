#pragma once

#include <corecrt_math.h>
#include <iostream>
#include <cstring> // Pour gérer les chaînes de caractères

class ElementStructurant {
public:
    const char* type;
    int hauteur;
    int largeur;
    unsigned char* data;
    unsigned char** pixel;

public:
    ElementStructurant(const ElementStructurant& _se){
        type = _se.type;
		hauteur = _se.hauteur;
		largeur = _se.largeur;
		allocation();
    }
    
    ElementStructurant() : type("V8"), hauteur(3), largeur(3) {
        allocation();
    }

    ElementStructurant(const char* type) : type(type), hauteur(3), largeur(3) {
        allocation();
    }

    ElementStructurant(const char* type, int hauteur, int largeur) : type(type), hauteur(hauteur), largeur(largeur) {
        allocation();
    }

    ~ElementStructurant() {
        deallocation();
    }

    void allocation();

    void allocation_ElementStructurant_rect(const char* type, int hauteur, int largeur);
    void allocation_ElementStructurant_ellipse(const char* type, int hauteur, int largeur);

    void deallocation(); // Pour libérer la mémoire allouée
};
