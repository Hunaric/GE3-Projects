#include <iostream>
#include <limits>

using namespace std;

int main() {
    int dossard, dossardVainqueur = 0, dossardDeuxieme = 0;
    double temps, meilleurTemps = numeric_limits<double>::max(), deuxiemeMeilleurTemps = numeric_limits<double>::max();

    while (true) {
        cout << "Entrez le dossard du skieur (0 pour terminer la saisie) : ";
        cin >> dossard;

        // Vérifier si la saisie est valide
        if (dossard == 0) {
            break; // Sortir de la boucle si le dossard est 0
        } else if (dossard < 1) {
            cout << "Erreur de saisie : Le dossard doit être un entier positif. Réessayez." << endl;
            cin.clear(); // Effacer les erreurs de saisie précédentes
            cin.ignore(numeric_limits<streamsize>::max(), '\n'); // Ignorer le reste de la ligne incorrecte
            continue; // Reprendre la saisie
        }

        cout << "Entrez le temps du skieur #" << dossard << " (en minutes) : ";
        cin >> temps;

        if (temps < meilleurTemps) {
            deuxiemeMeilleurTemps = meilleurTemps;
            dossardDeuxieme = dossardVainqueur;
            meilleurTemps = temps;
            dossardVainqueur = dossard;
        } else if (temps < deuxiemeMeilleurTemps && temps != meilleurTemps) {
            deuxiemeMeilleurTemps = temps;
            dossardDeuxieme = dossard;
        }
    }

    cout << "Le vainqueur est le skieur #" << dossardVainqueur << " avec un temps de " << meilleurTemps << " minutes." << endl;
    
    if (dossardDeuxieme != 0) {
        cout << "Le skieur ayant réalisé le deuxième meilleur temps est le skieur #" << dossardDeuxieme << " avec un temps de " << deuxiemeMeilleurTemps << " minutes." << endl;
    } else {
        cout << "Il n'y a pas de skieur avec le deuxième meilleur temps." << endl;
    }

    return 0;
}
