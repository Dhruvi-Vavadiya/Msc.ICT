//HashMap
import java.util.HashMap;

public class F {
    HashMap<String,Integer> cap=new HashMap<String,Integer>();
    HashMap<String,Integer> newMap=new HashMap<String,Integer>();
        
    public void Arr_1(){
        cap.put("Red",1 );
        cap.put("Green",2 );
        cap.put("Yellow",3 );
        cap.put("White",4);

        System.err.println("===: associate the specified value with the specified key in a  HashMap : ===");

        for(String i:cap.keySet()){
            System.out.println(" Key :"+ cap.get(i) +"  Value : " +i );
        }
    }
    public void Arr_2(){
        System.err.println("==== : count the number of key-value (size) mappings in a map : ===");

        System.out.println("Size of map is : "+cap.size());

    }
    public void Arr_3(){
        System.err.println("==== : copy all mappings from the specified map to another map : ===");
        newMap.put("Blue",5);
        newMap.put("Black",6);
        newMap.put("Pink",7);

        newMap.putAll(cap);
        System.out.println(newMap);
    }
    public void Arr_4(){
        System.err.println("==== : remove all mappings from a map : ===");

        // newMap.clear();
        System.out.println("Remove all mappings"+newMap);
      
    }
    public void Arr_5(){
        System.err.println("==== : check whether a map contains key-value mappings (empty) or not : ===");

        System.out.println("Empty : "+newMap.isEmpty());
        System.out.println("Empty : "+cap.isEmpty());
    }
    public void Arr_6(){
        System.err.println("==== : get a shallow copy of a HashMap instance : ===");

        HashMap clone=(HashMap)cap.clone();

        clone.remove("Red");
        System.out.println("Cap : "+cap);
        System.out.println("Clone : "+clone);
    }
    public void Arr_7(){
        System.err.println("==== : test if a map contains a mapping for the specified key : ===");

        System.out.println("Contains Key : "+cap.containsKey(4));

    }
    public void Arr_8(){
        System.err.println("==== : test if a map contains a mapping for the specified value : ===");

        System.out.println("Containes Value : "+cap.containsValue("Green"));

    }
    public void Arr_9(){
        System.err.println("==== : create a set view of the mappings contained in a map : ===");

        System.out.println(cap.entrySet());
    }
    public void Arr_10(){
        System.err.println("==== : get the value of a specified key in a map : ===");

        System.out.println(cap.get("Red"));
    }
    public void Arr_11(){
        System.err.println("==== : get a set view of the keys contained in this map : ===");

        System.out.println(cap.keySet());
    }
    public void Arr_12(){
        System.err.println("==== : get a collection view of the values contained in this map : ===");

        System.out.println(cap.values());
    }
    

    public static void main(String[] args) {
       
        F arr=new F();
        arr.Arr_1();
        arr.Arr_2();
        // arr.Arr_3();
        // arr.Arr_4();
        // arr.Arr_5();
        // arr.Arr_6();
        // arr.Arr_7();
        // arr.Arr_8();
        arr.Arr_9();
        // arr.Arr_10();
        // arr.Arr_11();
        // arr.Arr_12();
       

    }
}
