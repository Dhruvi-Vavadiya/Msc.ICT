import java.util.Scanner;
public class VigenereCipher {
   
    public static String encrypt(String plaintext, String keyword) { //Hello,World! //key
        StringBuilder ciphertext = new StringBuilder();
        keyword = keyword.toLowerCase(); //convert string in lowercase
        // System.out.println("keyword in lowercase :"+keyword);
        int keywordIndex = 0;
         
        for (char c : plaintext.toCharArray()) {
            // System.out.println("tochararray (c) :"+c);
            if (Character.isLetter(c)) { //isletter t/f

                char base = Character.isLowerCase(c) ? 'a' : 'A';
                
                // System.out.println("base :"+base);
                // System.out.printf("keywordIndex %d keyword.length() %d = %d \n",keywordIndex,keyword.length(),keywordIndex % keyword.length());
               
                int shift = keyword.charAt(keywordIndex % keyword.length()) - 'a';
                //                          0    %   3(key)
                //          key.charAt(0 % 3)-'a'
                // System.out.println("shift :"+shift);

                // System.out.printf("c-base+shift %c %c %d:\n", c,base, shift);

                char encryptedChar = (char) ((c - base + shift) % 26 + base);
                    //                      (H-A+10)%26+A
                //     System.err.println("sum :"+(11-0+24));
                //     System.out.println("Answer ::"+(11-0+24)%26);
                // System.out.println("encryptedChar :"+encryptedChar);

                ciphertext.append(encryptedChar);

                // System.out.println("ciphertext String = " + ciphertext.toString());
                keywordIndex++;
            } else {
                // System.err.printf("Non-alphabetic characters are preserved %c",c);
                ciphertext.append(c); // Non-alphabetic characters are preserved
                
            }
        }
        return ciphertext.toString();
    }
    public static String decrypt(String ciphertext, String keyword) {// kent //best
        StringBuilder plaintext = new StringBuilder(); //obj
        keyword = keyword.toLowerCase(); //convert lowercase(Best)
        int keywordIndex = 0;

        for (char c : ciphertext.toCharArray()) {
            if (Character.isLetter(c)) { //k
                System.err.println("c ::"+c);
                char base = Character.isLowerCase(c) ? 'a' : 'A'; //n=a
                int shift = keyword.charAt(keywordIndex % keyword.length()) - 'a'; //18

                 System.out.println("shift :"+shift);
                char decryptedChar = (char) ((c - base - shift+26 ) % 26 + base); //

                System.err.println("sum ::"+(13-0-18+26));
                // System.err.println("ans ::"+((17-0+10+26)%26+base));
                System.out.println("decryptedChar :"+decryptedChar);

                plaintext.append(decryptedChar);
                keywordIndex++;
            } else {
                plaintext.append(c); // Non-alphabetic characters are preserved
            }
        }
        return plaintext.toString();
    }
    

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        // char ch = "PHfss".charAt(2);
        // System.out.println(ch);
        System.err.println("53 m 2600 = "+53%26);
        System.err.println("0 m 4 = "+0%4);
        System.err.println("1 m 4 = "+1%4);
        // System.err.println("3 m 3 = "+3%3);
        // System.err.println("4 m 3 = "+4%3);
        // System.err.println("5 m 3 = "+5%3);
        // System.err.println("6 m 3 = "+6%3);
        // System.err.println("7 m 3 = "+7%3);
        String plaintext = "java";
        String keyword= "best";

        System.out.println("Plaintext: \n" + plaintext);
        // plaintext = sc.nextLine(); //ATTACKATDAWN
        // System.out.println("Plaintext: " + plaintext);

        System.out.println("keyword: \n" + keyword);
        // keyword = sc.nextLine(); //LEMON
        // System.out.println("keyword: " + keyword);

        String encrypted = encrypt(plaintext, keyword);
        System.out.println("Encrypted: " + encrypted);

        String decrypted = decrypt(encrypted, keyword);
        System.out.println("Decrypted :: " + decrypted);

       
    }
}