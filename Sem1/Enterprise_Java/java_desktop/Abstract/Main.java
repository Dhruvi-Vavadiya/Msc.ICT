// Mainkage Abstract;

abstract  class Animal {
    Animal(){
        System.out.println("I am a constructor of Animal");
    }
    public abstract void sound();
}

class dog extends Animal{
    dog(){
        super();
        System.out.println("I am a constructor of Dog");
    }
    public void sound(){
        System.out.println("Barking");
    }
}

class Tiger extends Animal{
    Tiger(){
        super();
        System.out.println("I am a constructor of Tiger");
    }
    public void sound(){
        System.out.println("Roaring");
    }
}
public class Main {
    public static void main(String[] args) {
        // Animal a = new dog();
        dog d = new dog();
        Tiger t = new Tiger();

        d.sound();
        t.sound();
    }
    
}
