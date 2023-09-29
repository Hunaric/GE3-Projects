#include <iostream>
#include <string>
#include<conio.h>
using namespace std;
class Adresse
{
private:
    /* data */
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

    void Afficher()
    {
        cout<<"Voici l'adresse : "<<X<<'.'<<Y<<'.'<<Z<<'.'<<T<<endl;
    }
};

bool verification_caractere (string lot_adresse)
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
        cout<<"----------------------- INFORMATIONS SUR L'ADRESSE -----------------------"<<endl<<endl;
        adresse.Afficher();
        cout<<endl;
        cout<<"La classe de l'adresse est : "<<classe_adresse(adresse.GetX())<<endl<<endl;
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
            cout<<"L'adresse saisie est priv\202e."<<endl<<endl;
        } else {
            cout<<"L'adresse saisie n'est pas priv\202e."<<endl<<endl;
        }

        string msr, ip_diffusion, plage1, plage2;

        // Masque de sous-réseau
        if (classe_adresse(adresse.GetX()) == 'A') {
            msr = "255.0.0.0";
        }
        else if (classe_adresse(adresse.GetX()) == 'B') {
            msr = "255.255.0.0";
        }
        else {
            msr = "255.255.255.0";
        }

        // Adresse de diffusion
        if (classe_adresse(adresse.GetX()) == 'A') {
            ip_diffusion = to_string(adresse.GetX()) + ".255.255.255";
        }
        else if (classe_adresse(adresse.GetX()) == 'B') {
            ip_diffusion = to_string(adresse.GetX()) + "." + to_string(adresse.GetY()) + ".255.255";
        }
        else {
            ip_diffusion = to_string(adresse.GetX()) + "." + to_string(adresse.GetY()) + "." + to_string(adresse.GetZ()) + ".255";
        }

        // Plage d'adresse hote
        if (classe_adresse(adresse.GetX()) == 'A') {
            plage1 = to_string(adresse.GetX()) + ".0.0.1";
            plage2 = to_string(adresse.GetX()) + ".255.255.254";
        }
        else if (classe_adresse(adresse.GetX()) == 'B') {
            plage1 = to_string(adresse.GetX()) + "." + to_string(adresse.GetY()) + ".0.1";
            plage2 = to_string(adresse.GetX()) + "." + to_string(adresse.GetY()) + ".255.254";
        }
        else {
            plage1 = to_string(adresse.GetX()) + "." + to_string(adresse.GetY()) + "." + to_string(adresse.GetZ()) + ".1";
            plage2 = to_string(adresse.GetX()) + "." + to_string(adresse.GetY()) + "." + to_string(adresse.GetZ()) + ".254";
        }


        cout<<"Masque de sous-r\202seau : "<<msr<<endl<<endl<<"Adresse de diffusion : "<<ip_diffusion<<endl<<endl;
        cout<<"Plage d'adresse : De "<<plage1<<" a "<<plage2<<endl<<endl;


        continuer = reessayer();
        if (continuer == false)
        {
            break;
        }
        cin.ignore();

    }
    cout<<endl;
    cout<<"Au revoir";

    return 0;
}
