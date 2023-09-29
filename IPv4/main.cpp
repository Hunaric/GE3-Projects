#include <iostream>
#include <string>
#include<conio.h>
#include "adresse.h"
using namespace std;

int main() {
    cout<<"Bienvenue dans l'application d\202di\202e aux adresses IPv4";
    bool mauvaise_adresse(false), continuer(true);
    while (continuer)
    {
        int A, B, C, D;
        // Saisie des X, Y, Z et T
        cout<<"L'adresse doit se pr\202senter sous la forme de X.Y.Z.T"<<endl;
        string a, b, c, d;
        cout<<"Veuillez entrer la valeur X : ";
        getline(cin, a);
        cout<<endl;
        cout<<"Veuillez entrer la valeur Y : ";
        getline(cin, b);
        cout<<endl;
        cout<<"Veuillez entrer la valeur Z : ";
        getline(cin, c);
        cout<<endl;
        cout<<"Veuillez entrer la valeur T : ";
        getline(cin, d);
        cout<<endl;

        // Vérification de l'état des données saisies
        if ((a == "" or verification_caractere(a)==true) or (b == "" or verification_caractere(b)==true) or (c == "" or verification_caractere(c)==true) or (d == "" or verification_caractere(d)==true))
        {
            mauvaise_adresse = true;
            erreur(mauvaise_adresse);
            continuer = reessayer();
            if (continuer == false)
            {
                break;
            }
            cin.ignore();
            continue;
        }

        A = valeur_int(a);
        B = valeur_int(b);
        C = valeur_int(c);
        D = valeur_int(d);

        // cout<<a<<endl;

        // Vérification de la valeur des données saisies
        if (verification_nombre_correct(A)==false or verification_nombre_correct(B)==false or verification_nombre_correct(C)==false or verification_nombre_correct(D)==false)
        {
            mauvaise_adresse = true;
            erreur(mauvaise_adresse);
            continuer = reessayer();
            if (continuer == false)
            {
                break;
            } 
            cin.ignore();
            continue;
        }

        Adresse adresse(A,B,C,D);
        adresse.Afficher();
        cout<<endl;
        cout<<"La classe de l'adresse est : "<<classe_adresse(adresse.GetX())<<endl;
        if (classe_adresse(adresse.GetX()) == 'D' or classe_adresse(adresse.GetX()) == 'E')
        {
            continuer = reessayer();
            if (continuer == false)
            {
                break;
            }
            cin.ignore();
            continue;
        }

        if (estPrive(adresse.GetX(), adresse.GetY()))
        {
            cout<<"L'adresse saisie est priv\202e."<<endl;
        } else {
            cout<<"L'adresse saisie n'est pas priv\202e."<<endl;
        }
        
        
        

    }
    cout<<endl;
    cout<<"Au revoir";
    
    return 0;
}