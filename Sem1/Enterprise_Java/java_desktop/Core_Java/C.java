//HashSet

import java.util.HashSet;
import java.util.Iterator;
import java.util.Set;
import java.util.TreeSet;

public class C {
    HashSet<String> h1 = new HashSet<String>();
    TreeSet<Integer> num = new TreeSet<Integer>();
    HashSet<String> h3 = new HashSet<String>();
    public void Arr_1(){
        //Q-1 Write a Java program to append the specified element to the end of a hash set.
        h1.add("Red");
        h1.add("Green");
        h1.add("Blue");
        h1.add("Yellow");

        System.out.println(h1);
    }
    public void Arr_2(){
       //Q-2 Write a Java program to iterate through all elements in a hash list.
       for (String i : h1) {
        System.out.println(i);
    }
    }
    public void Arr_3(){
         //Q-3 Write a Java program to get the number of elements in a hash set.
         System.out.println("Get the number of elements :: " + h1.size());

    }
    public void Arr_4(){
        //Q-4 Write a Java program to empty an hash set.
        // h1.removeAll(h1);
        System.out.println("Empty HashSet ::" + h1);
      
    }
    public void Arr_5(){
         //Q-5 Write a Java program to test if a hash set is empty or not.
        System.out.println("Empty HashSet ::" + h1.isEmpty());

    }
    public void Arr_6(){
          //Q-6 Write a Java program to clone a hash set to another hash set.
          HashSet<String> h2 = (HashSet<String>) h1.clone();

          System.out.println("h1 HashSet ::" + h1);
          System.out.println("h2 HashSet ::" + h2);
    }
    public void Arr_7(){
         //Q-7 Write a Java program to convert a hash set to an array.
         String[] array = new String[h1.size()];

         h1.toArray(array);
 
         for (String i : array) {
             System.out.println(i);
         }
    }
    public void Arr_8(){
        //Q-8 Write a Java program to convert a hash set to a tree set.
        Set<String> tree_set = new TreeSet<String>(h1);
        System.out.println("TreeSet ::" + tree_set);

    }
    public void Arr_9(){
        num.add(1);
        num.add(2);
        num.add(85);
        num.add(5);
        num.add(6);
        num.add(76);
        num.add(8);
        num.add(9);
        num.add(10);

        //Q-9 Write a Java program to find numbers less than 7 in a tree set.
        TreeSet<Integer> treeheadset = new TreeSet<Integer>();
        treeheadset = (TreeSet) num.headSet(7);
        Iterator iterator;
        iterator = treeheadset.iterator();

        while (iterator.hasNext()) {
            System.out.println(iterator.next());
        }
    }
    public void Arr_10(){
        h3.add("Red");
        h3.add("Black");
        h3.add("Blue");
        h3.add("Pink");

        // Q-10 Write a Java program to compare two hash set.
        for (String c : h1) {
            if (h3.contains(c)) {
                System.out.println(c + " is present in both arrayList");
            }
        }
    }
    public void Arr_11(){
        //Q-11 Write a Java program to compare two sets and retain elements that are the same.
        h1.retainAll(h3);
        System.out.println("Retainall ::" + h1);
    }
    public void Arr_12(){

        //Q-12 Write a Java program to remove all elements from a hash set.
        // h1.clear();
        System.out.println("RemoveAll ::" + h1);
    }
    

    public static void main(String[] args) {
       
    
        C arr=new C();
        arr.Arr_1();
        arr.Arr_2();
        arr.Arr_3();
        arr.Arr_4();
        arr.Arr_5();
        arr.Arr_6();
        arr.Arr_7();
        arr.Arr_8();
        arr.Arr_9();
        arr.Arr_10();
        arr.Arr_11();
        arr.Arr_12();
       

    }
}
