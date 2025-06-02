public class Table_Vignere {

    public static void main(String[] args) {
        final int ALPHABET_SIZE = 26;
        char[][] vigenereTable = new char[ALPHABET_SIZE][ALPHABET_SIZE];
        
        // Fill the Vigenère table
        fillVigenereTable(vigenereTable);
        
        // Print the Vigenère table
        printVigenereTable(vigenereTable);
    }
    
    private static void fillVigenereTable(char[][] table) {
        for (int i = 0; i < table.length; i++) {
            for (int j = 0; j < table[i].length; j++) {
                table[i][j] = (char) ('A' + (i + j) % table.length);
            }
        }
        
    }

    private static void printVigenereTable(char[][] table) {
        for (char[] row : table) {
            for (char c : row) {
                System.out.print(c + " ");
            }
            // System.out.println();
        }
    }
}
