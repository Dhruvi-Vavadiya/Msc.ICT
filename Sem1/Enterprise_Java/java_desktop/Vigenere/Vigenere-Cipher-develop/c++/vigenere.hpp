#ifndef __VIGENERE__
#define __VIGENERE__

#include <iostream>
#include <string>
#include <vector>

using namespace std;

class Vigenere {

private:

    string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

    vector<size_t> getCharPositions(string& str);

public:

    Vigenere();
    ~Vigenere();

    string encrypt(string text, string key);
    string decrypt(string cipher, string key);

};

#endif