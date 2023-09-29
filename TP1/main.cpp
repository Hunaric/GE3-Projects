#include <iostream>

using namespace std;

int main() {
    int an;
    bool bissextile = false;

    // Saisie de l'année
    cout << "Entrez une annee : ";
    cin >> an;

    // Vérifier si l'année est bissextile
    bissextile = ((an % 400 == 0) || ((an % 4 == 0) && (an % 100 != 0)));

    if (bissextile) {
        cout << "L'annee est bissextile" << endl;
    } else {
        cout << "L'annee n'est pas bissextile" << endl;
    }

    // Déterminer si un mois a 31 jours (par exemple, mois de janvier)
    int mois = 1; // 1 représente janvier
    // Saisie du mois
    cout << "Entrez un mois : ";
    cin >> mois;
    bool moisDe31Jours = (mois >= 1 && mois <= 12) && (mois == 1 || mois == 3 || mois == 5 || mois == 7 || mois == 8 || mois == 10 || mois == 12);

    if (moisDe31Jours) {
        cout << "Le mois a 31 jours" << endl;
    } else {
        cout << "Le mois n'a pas 31 jours" << endl;
    }

    // Tester la validité d'une date (date saisie) et calculer la date du lendemain
    int jour, mois2, an2;
    cout << "Entrez une date (jour mois annee) : ";
    cin >> jour >> mois2 >> an2;

    bool dateValide = true;
    int joursParMois[] = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}; // Jours dans chaque mois

    if (an2 % 400 == 0 || (an2 % 4 == 0 && an2 % 100 != 0)) {
        joursParMois[2] = 29; // Février a 29 jours en année bissextile
    }

    if (mois2 < 1 || mois2 > 12 || jour < 1 || jour > joursParMois[mois2]) {
        dateValide = false;
    }

    if (dateValide) {
        // Calculer la date du lendemain
        if (jour < joursParMois[mois2]) {
            jour++;
        } else {
            jour = 1;
            if (mois2 < 12) {
                mois2++;
            } else {
                mois2 = 1;
                an2++;
            }
        }

        cout << "Date valide. Date du lendemain : " << jour << "/" << mois2 << "/" << an2 << endl;
    } else {
        cout << "Date invalide." << endl;
    }

    return 0;
}
