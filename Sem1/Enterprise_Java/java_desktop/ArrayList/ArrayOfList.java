import java.util.*;

public class ArrayOfList {
    
   public static void main(String[] args) {

    // ArrayList<String> car=new ArrayList<String>(); 
     
    // car.add("Volvo");
    // car.add("BMW");
    // car.add("Ford");
    // car.add("Audi");
    // car.add("Toyota");
    // car.add("Honda");

    // System.out.println(car);

    // System.out.println("=======add=========");

    // car.add(0,"Honda");
    // System.out.println(car);

    // System.out.println("=======access=========");

    // car.get(0);
    // System.out.println(car);

    // System.out.println("=======change or set=========");

    // car.set(2,"java");
    // System.out.println(car);

    // System.out.println("=======remove=========");

    // car.remove(2);
    // System.out.println(car);

    // System.out.println("=======check size=========");

    // System.out.println(car.size());

    // System.out.println("=======loop itrate=========");

    // for(int i=0;i<car.size();i++){
    //     System.out.println(car.get(i)+" ");
    // }

    // System.out.println("=======sort + for each=========");

    // Collections.sort(car);
    // for (String i:car){
    //     System.out.println(i+" ");
    // }

    // System.out.println("=======clone copy of all array elements=========");

    // ArrayList car2=(ArrayList)car.clone();
    // System.out.println(car);
    // System.out.println(car2);

    // System.out.println("=======contains=========");

    // System.out.println(car.contains("Audi"));
    // System.out.println(car.contains("Toyota"));

    // // System.out.println("=======remove all element=========");

    // // car.clear();
    // // System.out.println("Done"+car);

    // System.out.println("=======indexof lastindexof=========");
    // System.out.println(car);
    // System.out.println(car.indexOf("Ford"));
    // System.out.println(car.lastIndexOf("Volvo"));


    ArrayList<String> color=new ArrayList<String>();

    color.add("red");
    color.add("blue");
    color.add("white");
    color.add("green");
    color.add("yellow");
    color.add("black");
    
    System.out.println("=======sort=========");

    color.sort(null);
    System.out.println(color);
   
    }
}
