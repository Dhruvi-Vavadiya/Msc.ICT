
import java.util.ArrayList;

public class ArrayListOfNum {

    public static void main(String[] args) {

        ArrayList<Integer> num = new ArrayList<Integer>();

        System.out.println("=======add ensureCapacity=========");
        
        num.ensureCapacity(10);
        for (int i = 1; i <= 15; i++) {
            num.add(i);
        }
        System.out.println(num);

        System.out.println("====removeif replaceall==========");

        // num.removeIf( n -> n % 2 == 0 );
        // System.out.println(num);
        num.replaceAll(n -> n + 1);
        System.out.println(num);

        ArrayList<Integer> num1 = new ArrayList<Integer>();

        num1.add(3);
        num1.add(2);
        num1.add(67);

        System.out.println("====Compare two array==========");

        num.retainAll(num1);

        System.out.println(num);

        System.out.println("====sort==========");
        


    }
}
