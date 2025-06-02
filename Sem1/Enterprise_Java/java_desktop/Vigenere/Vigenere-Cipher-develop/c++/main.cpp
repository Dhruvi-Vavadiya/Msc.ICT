#include <iostream>
#include <string>

#include "vigenere.hpp"

using namespace std;

int main(int argc, char const *argv[]) {
    
    string text;
    string key;

    cout << "Text: ";
    cin >> text;
    cout << "Key: ";
    cin >> key;

    Vigenere* vigenere = new Vigenere();
    string cipher = vigenere->encrypt(text, key);
    string plainText = vigenere->decrypt(cipher, key);
    delete vigenere;

    cout << "===============" << endl;
    cout << "Text: " << text << endl;
    cout << "Key: " << key << endl;
    cout << "Cipher: " << cipher << endl;
    cout << "Plain Text: " << plainText << endl;

    return 0;
}
