import java.util.*;

class Prime{
    public static void main(String[] args) {
        System.out.println("Hello World");

        Scanner sc = new Scanner(System.in);

        System.out.printf("Enter a number :: ");
        int n=sc.nextInt();

       

        
        boolean flag=true;

        for(int i=2;i<n;i++){ //i=2; 12<13;
            if(n%i==0){// 50%25==0
               flag=false;
               break;
            }
        }
       
       

        if(flag==false){
            System.out.printf("%d Not Prime",+n);
        }else{
            System.out.printf("%d Prime",+n);
        }
        
    }
}