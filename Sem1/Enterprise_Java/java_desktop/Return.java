import java.util.*;

public class Return {
    public static void main(String[] args) {
        
        Scanner sc=new Scanner(System.in);

        int n;

        System.out.print("Enter a number :: ");
        n=sc.nextInt();

        long ans=factorial(n);
        System.out.printf("Factorial of %d is %d",n,ans);
        
    }

    static long factorial(int n){
        int n1=1;
        for(int i=1;i<=n;i++)
            n1=n1*i;
        // System.out.printf("%5d",n1);
        return n1;
    }
}
