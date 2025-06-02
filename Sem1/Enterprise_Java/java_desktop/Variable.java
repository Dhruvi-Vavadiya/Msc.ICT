public class Variable {
 
    static int b=70; //static variable
    //class_name.staticvariable_name

    int c=30; //instance variable
    //create one object and access the object_name.variable_name

    public static void main(String[] args) {
        int a=10; //local variable
        System.out.printf("local variable %d ::",+a);

        System.out.printf("\nstatic variable %d ::",Variable.b);

        Variable obj=new Variable();
        System.out.printf("\ninstance variable %d ::",obj.c);
    }
}
