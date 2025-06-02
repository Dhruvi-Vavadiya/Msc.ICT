 class Main{
    public static void main(String[] args) {
        Animal ani=new Animal();
        Dong dong=new Dong();
        Cat cat=new Cat();

        ani.animalSound();
        dong.animalSound();
        cat.animalSound();
    }
}
 class Animal {
    public void animalSound(){
        System.out.println("The animal makes a sound");
    }
}
 class Dong extends Animal {
    public void animalSound(){
        System.out.println("The dog says: bow wow");
    }
}
 class Cat extends Animal {
    public void animalSound(){
        System.out.println("The cat says: meow meow");
    }
}


