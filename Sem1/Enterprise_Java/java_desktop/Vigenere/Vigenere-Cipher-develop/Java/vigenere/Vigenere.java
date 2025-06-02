package Java.vigenere;

import java.util.ArrayList;
import java.util.List;

public class Vigenere {

    private String chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

    public Vigenere() {
    }

    private List<Integer> getCharPositions(String str) {

        List<Integer> charsAtPos = new ArrayList<Integer>();
        for (int i = 0; i < str.length(); i++) {
            charsAtPos.add(chars.indexOf(str.charAt(i)));
        }

        return charsAtPos;
    }

    public String encrypt(String text, String key) {

        List<Integer> textCharAtPos = getCharPositions(text);
        List<Integer> keyCharAtPos = getCharPositions(key);

        int textLength = text.length();
        int keyLength = key.length();

        String cipher = "";
        int letter;

        for (int n = 0; n < textLength; n++) {
            letter = (textCharAtPos.get(n) + keyCharAtPos.get(n % keyLength));
            letter %= chars.length();
            cipher += chars.charAt(letter);
        }

        return cipher;
    }

    public String decrypt(String cipher, String key) {

        List<Integer> cipherCharAtPos = getCharPositions(cipher);
        List<Integer> keyCharAtPos = getCharPositions(key);

        int cipherLength = cipher.length();
        int keyLength = key.length();

        String plainText = "";
        int letter;

        for (int n = 0; n < cipherLength; n++) {
            letter = (cipherCharAtPos.get(n) - keyCharAtPos.get(n % keyLength));
            letter += chars.length();
            letter %= chars.length();
            plainText += chars.charAt(letter);
        }

        return plainText;
    }

}
