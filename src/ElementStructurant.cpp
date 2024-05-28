#include "ElementStructurant.h"

void ElementStructurant::allocation() {
    if (strcmp(type, "V4") == 0) {
        this->allocation_ElementStructurant_ellipse(type, 1, 1);
    }
    else if (strcmp(type, "V8") == 0) {
        this->allocation_ElementStructurant_rect(type, 3, 3);
    }
    else if (strcmp(type, "disk") == 0) {
        if (hauteur >= largeur) {
            this->allocation_ElementStructurant_ellipse(type, hauteur, hauteur);
        }
        else {
            this->allocation_ElementStructurant_ellipse(type, largeur, largeur);
        }
    }
    else if (strcmp(type, "rect") == 0) {
        this->allocation_ElementStructurant_rect(type, hauteur, largeur);
    }
    else if (strcmp(type, "ligV") == 0) {
        this->allocation_ElementStructurant_rect(type, hauteur, 1);
    }
    else if (strcmp(type, "ligH") == 0) {
        this->allocation_ElementStructurant_rect(type, 1, largeur);
    }
    else if (strcmp(type, "elli") == 0) {
        this->allocation_ElementStructurant_ellipse(type, hauteur, largeur);
    }
    else {
        std::cerr << "Type d'élément structurant inconnu: " << type << std::endl;
    }
}

//ElementStructurant ElementStructurant::allocation_ElementStructurant_rect(const char* type, int hauteur, int largeur) {
//    /*ElementStructurant ElementStructurant;
//
//    int tailleSE = hauteur * largeur;
//    ElementStructurant.data = new unsigned char[tailleSE];
//    if (ElementStructurant.data == nullptr) {
//        return ElementStructurant;
//    }
//
//    ElementStructurant.pixel = new unsigned char* [hauteur];
//    if (ElementStructurant.pixel == nullptr) {
//        delete[] ElementStructurant.data;
//        ElementStructurant.data = nullptr;
//        return ElementStructurant;
//    }
//
//    for (int i = 0; i < hauteur; i++) {
//        ElementStructurant.pixel[i] = &ElementStructurant.data[i * largeur];
//    }
//
//    for (int i = 0; i < hauteur; i++) {
//        for (int j = 0; j < largeur; j++) {
//            ElementStructurant.pixel[i][j] = 1;
//        }
//    }
//    return ElementStructurant;*/
//    return ElementStructurant(type, hauteur, largeur);
//}

void ElementStructurant::allocation_ElementStructurant_rect(const char* type, int hauteur, int largeur)
{
    this->type = type;
    this->hauteur = hauteur;
    this->largeur = largeur;

    int tailleSE = hauteur * largeur;
    data = new unsigned char[tailleSE];
    if (data == nullptr) {
        std::cerr << "Erreur d'allocation de mémoire" << std::endl;
        return;
    }

    pixel = new unsigned char* [hauteur];
    if (pixel == nullptr) {
        delete[] data;
        data = nullptr;
        std::cerr << "Erreur d'allocation de mémoire" << std::endl;
        return;
    }

    for (int i = 0; i < hauteur; i++) {
        pixel[i] = &data[i * largeur];
    }

    for (int i = 0; i < hauteur; i++) {
        for (int j = 0; j < largeur; j++) {
            pixel[i][j] = 1;
        }
    }
}

void ElementStructurant::allocation_ElementStructurant_ellipse(const char* type, int hauteur, int largeur) {
    this->type = type;
    this->hauteur = 2 * hauteur + 1;
    this->largeur = 2 * largeur + 1;

    int tailleSE = this->hauteur * this->largeur;
    data = new unsigned char[tailleSE];
    if (data == nullptr) {
        std::cerr << "Erreur d'allocation de mémoire" << std::endl;
        return;
    }

    pixel = new unsigned char* [this->hauteur];
    if (pixel == nullptr) {
        delete[] data;
        data = nullptr;
        std::cerr << "Erreur d'allocation de mémoire" << std::endl;
        return;
    }

    for (int i = 0; i < this->hauteur; i++) {
        pixel[i] = &data[i * this->largeur];
    }

    int centerX = largeur;
    int centerY = hauteur;
    double x, y;
    double test;

    for (int i = 0; i < this->hauteur; i++) {
        for (int j = 0; j < this->largeur; j++) {
            x = (j - centerX) * 1.0 / largeur;
            y = (i - centerY) * 1.0 / hauteur;
            test = x * x + y * y;

            if (test <= 1) {
                pixel[i][j] = 1;
            }
            else {
                pixel[i][j] = 0;
            }
        }
    }
}
void ElementStructurant::deallocation() {
    if (pixel != nullptr) {
        delete[] pixel;
        pixel = nullptr;
    }
    if (data != nullptr) {
        delete[] data;
        data = nullptr;
    }
}