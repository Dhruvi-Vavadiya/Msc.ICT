//LinkedLists
import java.util.*;

public class B {

    LinkedList<String> f1 = new LinkedList<String>();
    LinkedList<String> f2 = new LinkedList<String>();
    LinkedList<String> f3 = new LinkedList<String>();

    public void Arr_1() {
        f1.add("WaterMelon");
        f1.add("Jambu");
        f1.add("Barry");
        f1.add("Mango");
        f1.add("Banana");

        System.out.println("===== :  Original List : =====");
        System.out.println(f1);

        //Q-1
        System.out.println("===== :  Append to to end : =====");

        // System.out.printf("Adding element to the end of the list:\n");
        // String s1=sc.next();
        f1.addLast("s1");
        System.out.println(f1);
    }

    public void Arr_2() {
        //Q-2
        System.out.println("===== :  Iterate through all elements in a linked list : =====");
        for (String i : f1) {
            System.out.println(i);
        }
    }

    public void Arr_3() {
        //Q-3
        System.out.println("===== :  Iterate through all elements in a linked list starting at the specified position : =====");
        for (int i = 2; i < f1.size(); i++) {
            System.out.println(f1.get(i));
        }

    }

    public void Arr_4() {
        //Q-4
        ListIterator<String> it = f1.listIterator();
        System.out.println("===== :  Iterate a linked list in reverse order : =====");

        while (it.hasNext()) {
            System.out.println(it.next());
        }
        System.out.println("=====");
        while (it.hasPrevious()) {
            System.out.println(it.previous());
        }

    }

    public void Arr_5() {
        //Q-5
        System.out.println("==== : set spectific postion : =====");
        f1.set(2, "Apple");
        System.out.println(f1);
    }

    public void Arr_6() {
        //Q-6
        System.out.println("==== : Insert elements into the linked list at the first and last positions : =====");
        f1.addFirst("Gavava");
        f1.addLast("Orange");
        System.out.println(f1);
    }

    public void Arr_7() {
        //Q-7
        System.out.println("==== : Insert the specified element at the front of a linked list : =====");
        f1.addFirst("Abc");
        System.out.println(f1);
    }

    public void Arr_8() {
        //Q-8
        System.out.println("==== : Insert the specified element at the end of a linked list : =====");
        f1.addLast("Xyz");
        System.out.println(f1);
    }

    public void Arr_9() {
        //Q-9
        System.out.println("==== : Insert some elements at the specified position into a linked list : =====");

        f2.add("Pineapple");
        f2.add("Lemon");
        f2.add("Chiku");
        f2.add("Papaya");

        f2.addAll(f1);

        System.out.println(f2);
    }

    public void Arr_10() {
        //Q-10
        System.out.println("==== : Get the first and last occurrence of the specified elements in a linked list : =====");

        System.out.println(f1.getFirst());
        System.err.println(f1.getLast());
    }

    public void Arr_11() {
        //Q-11
        System.out.println("==== : Display elements and their positions in a linked list : =====");
        for (int i = 0; i < f1.size(); i++) {
            System.out.println(i + " " + f1.get(i));
        }
    }

    public void Arr_12() {
        //Q-12
        System.out.println("==== : Remove a specified element from a linked list : =====");
        f1.remove("Banana");
        System.out.println(f1);
    }

    public void Arr_13() {
        //Q-13
        System.out.println("==== : Remove the first and last elements from a linked list : =====");
        f1.removeFirst();
        f1.removeLast();
        System.out.println(f1);

    }

    public void Arr_14() {
        //Q-14
        System.out.println("==== : Remove all elements from a linked list : =====");
        System.out.println(f2);
        f2.clear();
        System.out.println(f2);

    }

    public void Arr_15() {
        //Q-15
        System.err.println("==== : swaps two elements in a linked list : =====");

        System.out.println(f1);
        Collections.swap(f1, 0, 2);
        System.out.println(f1);
    }

    public void Arr_16() {
        //Q-16
        System.out.println("==== : shuffle elements in a linked list : =====");

        Collections.shuffle(f1);
        System.out.println(f1);

    }

    public void Arr_17() {
        //Q-17
        System.out.println("==== : join two linked list : =====");

        f3.addAll(f1);
        f2.add("Grapes");
        f3.addAll(f2);

        System.out.println(f3);

    }

    public void Arr_18() {
        //Q-18
        System.out.println("==== : copy  linked list to another linked list : =====");

        LinkedList<String> f4 = (LinkedList<String>) f2.clone();
        System.out.println(f4);
    }

    public void Arr_19() {
        System.out.println("==== : remove and return the first element of a linked list: =====");

        System.out.println(f1.pop());
    }

    public void Arr_20_21() {
        //Q-20 or Q-21
        System.out.println("==== : retrive first and last element but not remove in the linked list: =====");

        System.err.println(f1);
        System.out.println(f1.getFirst());
        System.err.println(f1);
        System.out.println(f1.getLast());
    }

    public void Arr_22() {
        //Q-22
        System.out.println("==== : check if the linked list contains the specified element: =====");

        System.err.println("banana ::"+f1.contains("Banana"));
        System.err.println(f1.contains("Grapes"));
        System.err.println(f1.contains("Mango"));
    }

    public void Arr_23() {
        //Q-23
        System.out.println("==== :  convert a linked list to an array list: =====");

        List<String> f5 = new ArrayList<String>(f1);

        System.out.println(f5);

    }

    public void Arr_24() {
        //Q-24
        System.out.println("==== :  compare two linked lists : =====");

        System.out.printf("First Linked List : %s\n", f1);
        System.out.printf("Second Linked List : %s\n", f3);

        f1.retainAll(f3);
        System.out.println(f1);

    }

    public void Arr_25() {
        //Q-25
        System.out.println("==== :  linked list is empty or not : =====");

        System.out.println(f1.isEmpty());
        f2.remove();
        System.out.println(f2.isEmpty());
    }

    public void Arr_26() {

        //Q-26
        System.out.println("==== : replace an element in a linked list : =====");
        System.err.println(f1);
        f1.set(2, "Orange");
        System.out.println(f1);
    }

    public static void main(String[] args) {
        // Scanner sc=new Scanner(System.in);

        B arr = new B();
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
        arr.Arr_13();
        arr.Arr_14();
        arr.Arr_15();
        arr.Arr_16();
        arr.Arr_17();
        arr.Arr_18();
        arr.Arr_19();
        arr.Arr_20_21();
        arr.Arr_22();
        arr.Arr_23();
        arr.Arr_24();
        arr.Arr_25();
        arr.Arr_26();

    }
}
