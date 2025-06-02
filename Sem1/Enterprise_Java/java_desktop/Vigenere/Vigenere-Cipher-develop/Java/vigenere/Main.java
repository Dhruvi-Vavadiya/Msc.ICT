package Java.vigenere;

import Java.vigenere.Vigenere;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        
        String text = "";
        String key = "";

        try(Scanner scanner = new Scanner(System.in)) {
            
            System.out.print("Text: ");
            text = scanner.nextLine();

            System.out.print("Key: ");
            key = scanner.nextLine();
            
        }catch (Exception ex) {
            System.out.println(ex);
        }

        Vigenere vigenere = new Vigenere();
        String cipher = vigenere.encrypt(text, key);
        String plainText = vigenere.decrypt(cipher, key);

        System.out.println("======================");
        System.out.println("Text: " + text);
        System.out.println("Key: " + key);
        System.out.println("Cipher: " + cipher);
        System.out.println("Plain Text: " + plainText);

    }
}
