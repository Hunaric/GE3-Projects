#ifndef ADRESSE_H
#define ADRESSE_H
#include <iostream>
#include <string>
#include<conio.h>
using namespace std;


class Adresse {
    private:
        /* données */
        int X, Y, Z, T;
    public:
        Adresse(int x, int y, int z, int t) {
            X = x;
            Y = y;
            Z = z;
            T = t;
        };

        int GetX() {return X;}
        int GetY() {return Y;}
        int GetZ() {return Z;}
        int GetT() {return T;}

        void SetX(int x)    {X = x;}
        void SetY(int y)    {Y = y;}
        void SetZ(int z)    {Z = z;}
        void SetT(int t)    {T = t;}
        void Afficher();
};

bool verification_caractere(const std::string& lot_adresse);
void erreur(bool mauvais);
bool reessayer();
int valeur_int(string lot);
bool verification_nombre_correct (int a);
bool estPrive(int x, int y);
char classe_adresse(int lot);

#endif