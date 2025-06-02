import java.util.*;
interface client{
    void input();
    void output();
}

class Dhruvi implements client{
    Scanner sc=new Scanner(System.in);
    String nm;
    double sal;

    public void input(){
        System.out.println("Enter name:");
        nm=sc.nextLine();
        System.out.println("Enter salary:");
        sal=sc.nextDouble();
    }
    public void output(){
        System.out.println(nm+"  "+sal);
    }

    public static void main(String[] args){
        client c=new Dhruvi();
        c.input();
        c.output();
    }
}