#include <iostream>
#include <cstdlib>
#include <ctime>
#include <vector>
#include <algorithm>

using namespace std;

const int MAX_ATTEMPTS = 10; // Nombre maximum de tentatives

// Génère une combinaison cachée aléatoire de 5 numéros (de 1 à 9)
vector<int> genererCombinaisonCachee() {
    vector<int> combinaison;
    srand(time(nullptr)); // Initialisation du générateur de nombres aléatoires

    for (int i = 0; i < 5; i++) {
        int numero = rand() % 9 + 1; // Génère un nombre aléatoire entre 1 et 9
        combinaison.push_back(numero);
    }

    return combinaison;
}

// Compare la proposition du joueur avec la combinaison cachée
pair<int, int> analyserProposition(const vector<int>& combinaisonCachee, const vector<int>& proposition) {
    int bienPlaces = 0;
    int numerosCorrects = 0;

    for (int i = 0; i < 5; i++) {
        if (proposition[i] == combinaisonCachee[i]) {
            bienPlaces++;
        } else if (find(combinaisonCachee.begin(), combinaisonCachee.end(), proposition[i]) != combinaisonCachee.end()) {
            numerosCorrects++;
        }
    }

    return make_pair(bienPlaces, numerosCorrects);
}

int main() {
    vector<int> combinaisonCachee = genererCombinaisonCachee();
    vector<int> proposition;

    cout << "Bienvenue dans le jeu Mastermind !" << endl;
    cout << "Devinez la combinaison cachee de 5 numeros (de 1 a 9)." << endl;
    cout << "Vous avez " << MAX_ATTEMPTS << " tentatives pour trouver la bonne combinaison." << endl;

    for (int essai = 1; essai <= MAX_ATTEMPTS; essai++) {
        proposition.clear();

        cout << "Tentative #" << essai << ": ";
        for (int i = 0; i < 5; i++) {
            int numero;
            cin >> numero;
            proposition.push_back(numero);
        }

        pair<int, int> resultat = analyserProposition(combinaisonCachee, proposition);
        cout << resultat.first << " numeros bien places, " << resultat.second << " numeros corrects." << endl;

        if (resultat.first == 5) {
            cout << "Bravo, vous avez gagne en " << essai << " essais !" << endl;
            break;
        }

        if (essai == MAX_ATTEMPTS) {
            cout << "Vous avez perdu ! La bonne combinaison etait : ";
            for (int num : combinaisonCachee) {
                cout << num << " ";
            }
            cout << endl;
        }
    }

    return 0;
}
