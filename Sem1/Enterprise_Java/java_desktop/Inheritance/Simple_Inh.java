// package Inheritance;
//Simple Inheritance

//  class Vehical{
//     protected String speed="120";
//     public void car(int x){
//         System.out.println("car "+x);
//     }
// }
// public class Simple_Inh extends Vehical{
//     public String name="Audi";

//     public static void main(String[] args) {
//         Simple_Inh myObj=new Simple_Inh();

//         myObj.car(5); //method called from child class
    
//         System.out.println(myObj.name+" " +myObj.speed);
//     }
// }

//Multilevel Inheritance

// class animal{
//     void eat(){
//         System.out.println("animal eating");
//     }
// }
// class dog extends animal{
//     void bark(){
//         System.out.println("dog barking");
//     }
// }
// class BabyDog extends dog{
//     void meow(){
//         System.out.println("cat meowing");
//     }
// }

// class Simple_Inh {
//     public static void main(String[] args) {
//         BabyDog myObj=new BabyDog();

//         myObj.meow();
//         myObj.bark();
//         myObj.eat();
//     }
// }

//getter and setter methods

class Base{
    int x;

     Base(){
        System.out.println("I am Constructor");
    }
    Base(int x){
        System.out.println("I am Overloaded Constructor with value of X as: "+x);
    }
}

class Drived extends Base{
    int y;

   
     Drived(){
        // super(5);
        System.out.println("I am Drived Constructor");
    }
    Drived(int x,int y){
        super(x);
        System.out.println("I am Overloaded Constructor with value of y as: "+y);
    }
}

class ChildOfDrived extends Drived{

     ChildOfDrived() {
        System.err.println("I am Child of Drived Constructor");
    }

    public ChildOfDrived(int x, int y, int z) {
        super(x, y);
        System.out.println("I am Overloaded Constructor with value of z as: "+z);
    }

    
}

public class Simple_Inh{

    public static void main(String[] args){
        // Base b = new Base();
        // Drived d = new Drived(4,9);
        
        ChildOfDrived cd = new ChildOfDrived(1, 2,3);
    }
}

