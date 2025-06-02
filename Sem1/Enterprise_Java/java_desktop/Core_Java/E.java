//PriorityQueue
import java.util.*;

public class E {
    PriorityQueue<String> p1=new PriorityQueue<String>();
    PriorityQueue<String> p2=new PriorityQueue<String>();
    
    public void Arr_1(){
        p1.add("Red");
        p1.add("Green");
        p1.add("Blue");
        p1.add("Yellow");
        p1.add("White");
        //Q1. Write a Java program to create a priority queue, add some colors (strings) and print out the elements of the priority queue. 
        System.out.println("p1 :: "+p1);
    }
    public void Arr_2(){
        //Q2. Write a Java program to iterate through all elements in the priority queue.
        for(String i:p1){
            System.err.println(i);
        }
    }
    public void Arr_3(){
        //Q3. Write a Java program to add all the elements of a priority queue to another priority queue.
        p2.addAll(p1);

        System.err.println("p2 :: "+p2);
    }
    public void Arr_4(){
        //Q4. Write a Java program to insert a given element into a priority queue.
        p2.offer("Black");
        System.out.println("p2 :: "+p2);
      
    }
    public void Arr_5(){
        //Q5. Write a Java program to remove all elements from a priority queue.
        //   p2.clear();
        System.out.println("p2 is empty now:: "+p2);
    }
    public void Arr_6(){
        //Q6. Write a Java program to count the number of elements in a priority queue.
        System.out.println("p1 size :: "+p1.size());
    }
    public void Arr_7(){
        //Q7. Write a Java program to compare two priority queues.
        for(String ele:p1){
            System.out.println(p2.contains(ele)?"Yes":"No");
        }
    }
    public void Arr_8(){
        //Q8. Write a Java program to retrieve the first element of the priority queue.
        System.out.println("First element of p1 :: "+p1.peek());

    }
    public void Arr_9(){
        //Q9. Write a Java program to retrieve and remove the first element.
        System.out.println("retrive and remove First element of p1 :: "+p1.poll());
        System.out.println("p1 :: "+p1);
    }
    public void Arr_10(){
        //Q10. Write a Java program to convert a priority queue to an array containing all its elements.
        List<String> arr=new ArrayList<String>(p1);

        System.out.println("Array :: "+arr);
    }
    public void Arr_11(){
        //Q11. Write a Java program to convert a Priority Queue element to string representations.
        System.out.println("String representation of p1 :: "+p1.toString());

    }
    public void Arr_12(){
        //Q12. Write a Java program to change priorityQueue to maximum priority queue.
        List<String> tempList = new ArrayList<>(p1);
        Collections.sort(tempList, Collections.reverseOrder());
        p1.clear();
        p1.addAll(tempList);

        System.out.println("Maximum priority queue: " + p1);
        
    }
    

    public static void main(String[] args) {
       
        E arr=new E();
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
