#include <iostream>
#include <string>
#include<conio.h>
#include "adresse.h"
using namespace std;

// Définition du constructeur de la classe Adresse
Adresse::Adresse(int x, int y, int z, int t) {
    X = x;
    Y = y;
    Z = z;
    T = t;
}

// Définition des méthodes de la classe Adresse
int Adresse::GetX() { return X; }
int Adresse::GetY() { return Y; }
int Adresse::GetZ() { return Z; }
int Adresse::GetT() { return T; }
void Adresse::SetX(int x) { X = x; }
void Adresse::SetY(int y) { Y = y; }
void Adresse::SetZ(int z) { Z = z; }
void Adresse::SetT(int t) { T = t; }

void Adresse::Afficher()
{
    cout<<"Voici l'adresse : "<<X<<'.'<<Y<<'.'<<Z<<'.'<<T<<endl;
}

// Définition des fonctions non membres
bool verification_caractere (const std::string& lot_adresse)
{
    bool has_non_numeric = false;
    for (char c : lot_adresse)
    {
        if (!isdigit(c))
        {
            has_non_numeric = true;
            // break;
        }
    }
    return has_non_numeric;
    
}

void erreur(bool mauvais)
{   
    if (mauvais == true)
    {
        cout<<"L'adresse saisie est incorrecte"<<endl;
    }
    
}

bool reessayer()
{
    char lettre;
    bool rep;
    cout<<"Souhaitez vous r\202essayer ? ";
    cin>>lettre;
    if(lettre == 'O' or lettre == 'o')
    {
        rep = true;
    } else {
        rep = false;
    }
    return rep;
}

int valeur_int(string lot)
{
    int intValue = 0;
    for (char c : lot)
    {
        intValue = intValue * 10 + (c - '0');
    }
    return intValue;
}

bool verification_nombre_correct (int a)
{
    bool bon = false;
    if(a>=0 and a<=255)
    {
        bon = true;
    }
    return bon;
}

bool estPrive(int x, int y)
{
    return ((x == 10) || (x == 172 && (y >= 16 && y <=31)) || (x == 192 && y == 168));
}

char classe_adresse(int lot)
{
    if (lot >= 0 and lot <=127) {
        return 'A';
    } 
    else if (lot >= 128 and lot <=191) {
        return 'B';
    }
    else if (lot >= 192 and lot <=223) {
        return 'C';
    } 
    else if (lot >= 224 and lot <=239) {
        return 'D';
    }
    else {
        return 'E';
    }
}