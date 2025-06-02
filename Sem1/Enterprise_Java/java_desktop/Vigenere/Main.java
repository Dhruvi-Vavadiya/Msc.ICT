import java.util.Scanner;
public class Main {
    public static String encrypt(String plaintext, String keyword) { // Java.//best
        StringBuilder ciphertext = new StringBuilder(); //obj
        keyword = keyword.toLowerCase(); //convert lowercase(BEST=best)
        int keywordIndex = 0;

        for (char c : plaintext.toCharArray()) {
            if (Character.isLetter(c)) {  //j a v a
                char base = Character.isLowerCase(c) ? 'a' : 'A'; //J=A //a=a //v=a //a=a
                int shift = keyword.charAt(keywordIndex % keyword.length()) - 'a'; //1=b //4=e //18=s //19=t
                char encryptedChar = (char) ((c - base + shift) % 26 + base); //10=K //4=e // 39%26=13=n //19=t
                ciphertext.append(encryptedChar); //append K e n t
                keywordIndex++;
            } else {
                ciphertext.append(c); // .
            }
        }
        return ciphertext.toString(); 
    }

    public static String decrypt(String ciphertext, String keyword) {// Kent. //BEST
        StringBuilder plaintext = new StringBuilder(); //obj
        keyword = keyword.toLowerCase(); //convert lowercase(BEST=best)
        int keywordIndex = 0;

        for (char c : ciphertext.toCharArray()) {
            if (Character.isLetter(c)) { //k e n t
                char base = Character.isLowerCase(c) ? 'a' : 'A'; //k=A //e=a //n=a //t=a
                int shift = keyword.charAt(keywordIndex % keyword.length()) - 'a'; //1=b //4=e //18-s //19-t
                char decryptedChar = (char) ((c - base - shift + 26) % 26 + base); //9-j // 0-a //21-v //0-a
                plaintext.append(decryptedChar); //append j a v a
                keywordIndex++;
            } else {
                plaintext.append(c); // .
            }
        }
        return plaintext.toString();
    }

    public static void main(String[] args) {
        Scanner sc=new Scanner(System.in);
        String plaintext;
        String keyword;

        System.out.printf("Enter the plaintext :: ");
        plaintext = sc.nextLine();
        System.out.printf("Enter the keyword :: ");
        keyword = sc.nextLine();

        System.out.println("================================");


        String encrypted = encrypt(plaintext, keyword);
        System.out.println("Encrypted :: " + encrypted);

         String decrypted = decrypt(encrypted, keyword);
        System.out.println("Decrypted :: " + decrypted);
    }
}