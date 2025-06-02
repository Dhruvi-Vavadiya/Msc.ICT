#include "vigenere.hpp"

Vigenere::Vigenere() {}
Vigenere::~Vigenere() {}

vector<size_t> Vigenere::getCharPositions(string& str) {

    vector<size_t> charsAtPos;
    for (int i = 0; i < str.length(); i++) {
        charsAtPos.push_back(chars.find(str.at(i)));
    }

    return charsAtPos;
}

string Vigenere::encrypt(string text, string key) {

    vector<size_t> textCharAtPos = getCharPositions(text);
    vector<size_t> keyCharAtPos = getCharPositions(key);

    size_t textLength = text.length();
    size_t keyLength = key.length();

    string cipher;
    int letter;

    for (int n = 0; n < textLength; n++) {
        letter = (textCharAtPos.at(n) + keyCharAtPos.at(n % keyLength));
        letter %= chars.length();
        cipher += chars.at(letter);
    }

    return cipher;
}

string Vigenere::decrypt(string cipher, string key) {

    vector<size_t> cipherCharAtPos = getCharPositions(cipher);
    vector<size_t> keyCharAtPos = getCharPositions(key);

    size_t cipherLength = cipher.length();
    size_t keyLength = key.length();

    string plainText;
    int letter;

    for (int n = 0; n < cipherLength; n++) {
        letter = (cipherCharAtPos[n] - keyCharAtPos[n % keyLength]);
        letter += chars.length();
        letter %= chars.length();
        plainText += chars.at(letter);
    }

    return plainText;
}