#include <iostream>
#include <limits> // Pour la gestion d'erreur de saisie

using namespace std;

int main() {
    int dosse, dossmt;
    double tc, mt;

    // Initialisation des variables avec des valeurs maximum possibles
    mt = numeric_limits<double>::max();
    dossmt = -1;

    cout << "Saisissez le dossard et le temps de chaque concurrent (dossard 0 pour terminer) : " << endl;

    while (true) {
        cout << "Dossard : ";
        if (!(cin >> dosse) || dosse < 0) {
            cerr << "Erreur de saisie du dossard. Veuillez saisir un entier positif." << endl;
            cin.clear();
            cin.ignore(numeric_limits<streamsize>::max(), '\n');
            continue;
        }

        if (dosse == 0) {
            break; // Sortie de la boucle si le dossard est 0
        }

        cout << "Temps : ";
        if (!(cin >> tc) || tc <= 0) {
            cerr << "Erreur de saisie du temps. Veuillez saisir un nombre positif." << endl;
            cin.clear();
            cin.ignore(numeric_limits<streamsize>::max(), '\n');
            continue;
        }

        if (tc < mt) {
            mt = tc;
            dossmt = dosse;
        }
    }

    if (dossmt != -1) {
        cout << "Le vainqueur est le skieur avec le dossard " << dossmt << " et son temps est de " << mt << " minutes." << endl;
    } else {
        cout << "Aucune donnée valide saisie." << endl;
    }

    return 0;
}
