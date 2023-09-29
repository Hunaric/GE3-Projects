// Pour la vérification des valeurs 
#include <iostream>
#include <string>

int main() {
    std::string inputString;

    // Demandez à l'utilisateur de saisir une chaîne de caractères
    std::cout << "Entrez une chaîne de caractères : ";
    std::cin >> inputString;

    // Variable pour stocker la conversion en entier
    int intValue = 0;

    // Variable pour indiquer s'il y a des caractères non numériques
    bool hasNonNumeric = false;

    // Parcourez chaque caractère de la chaîne
    for (char c : inputString) {
        if (isdigit(c)) {
            // Si le caractère est un chiffre, ajoutez sa valeur à intValue
            intValue = intValue * 10 + (c - '0');
        } else {
            // Si le caractère n'est pas un chiffre, définissez hasNonNumeric à true
            hasNonNumeric = true;
            break; // Sortez de la boucle dès que vous trouvez un caractère non numérique
        }
    }

    // Vérifiez si la chaîne contient des caractères non numériques
    if (hasNonNumeric) {
        std::cout << "Erreur : La chaîne contient des caractères non numériques." << std::endl;
    } else {
        // Si la chaîne est entièrement numérique, affichez la valeur convertie en entier
        std::cout << "Valeur en entier : " << intValue << std::endl;
    }

    return 0;
}

// Pour la saie de X, Y, Z et T
#include <iostream>
#include <string>
#include <vector>
#include <sstream>

int main() {
    std::string inputString;

    // Demandez à l'utilisateur de saisir une chaîne de caractères
    std::cout << "Entrez une chaîne de caractères : ";
    std::cin >> inputString;

    // Utilisez un flux de chaînes pour diviser la chaîne en tokens en fonction du point ('.')
    std::stringstream ss(inputString);
    std::string token;
    std::vector<std::string> tokens;

    while (std::getline(ss, token, '.')) {
        tokens.push_back(token);
    }

    // Maintenant, vous avez une liste de tokens dans le vecteur "tokens"
    // Vous pouvez accéder aux parties X, Y, Z et T en fonction de leur position dans le vecteur

    if (tokens.size() >= 1) {
        std::cout << "X = " << tokens[0] << std::endl;
    }
    if (tokens.size() >= 2) {
        std::cout << "Y = " << tokens[1] << std::endl;
    }
    if (tokens.size() >= 3) {
        std::cout << "Z = " << tokens[2] << std::endl;
    }
    if (tokens.size() >= 4) {
        std::cout << "T = " << tokens[3] << std::endl;
    }

    return 0;
}

// Convertion int en str
#include <iostream>
#include <sstream>

int main() {
    int number = 123; // Votre nombre entier
    std::ostringstream convert; // Créez un objet std::ostringstream

    // Utilisez l'opérateur << pour insérer le nombre dans l'objet std::ostringstream
    convert << number;

    // Obtenez la chaîne de caractères résultante en utilisant la méthode str()
    std::string result = convert.str();

    // Affichez la chaîne résultante
    std::cout << "La chaîne résultante : " << result << std::endl;

    return 0;
}
