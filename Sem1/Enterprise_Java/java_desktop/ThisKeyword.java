// public class ThisKeyword {
    
//     int a;
//     int b;
//     ThisKeyword(){
//         this(10,20);
//         System.out.println("default constructor");
//     }
//     ThisKeyword(int a,int b){
//         // It initializes the instance variables this.a and this.b with the values passed to the constructor.   
//         this.a=a;
//         this.b=b;
//         System.out.println("parameterized constructor");
//     }
//     public static void main(String[] args) {
//         ThisKeyword obj=new ThisKeyword();
//         System.out.println(obj.a);
//         System.out.println(obj.b);
        
//     }
// }

// public class ThisKeyword{
//     int a;
//     ThisKeyword(int x){
//         this.a=x;
//     }
//     void show(){
//         System.out.println("show method ::"+a);
//     }

//     public static void main(String[] args) {
//         ThisKeyword obj=new ThisKeyword(100);

//         // System.out.println("Main method ::"+obj);
//         obj.show();
//     }
// }

//default constructor

// public class ThisKeyword{

//     ThisKeyword(){
//         System.out.println("default constructor");
//     }
//     ThisKeyword(int a){
//         this();
//         System.out.println("parameterized constructor"+a);
//     }

//     public static void main(String[] args) {
//         ThisKeyword obj=new ThisKeyword(10);

//     }
// }

//parameterized constructor

public class ThisKeyword{

    ThisKeyword(){
        this(10,8.5);
    }
    ThisKeyword(int a,double b){
        System.out.println("parameterized constructor ::"+a+b);
    }

    public static void main(String[] args) {
        ThisKeyword obj=new ThisKeyword();

    }}