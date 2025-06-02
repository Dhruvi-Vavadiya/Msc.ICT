//TreeSet

import java.util.Iterator;
import java.util.TreeSet;

public class D {

    TreeSet<String> t1 = new TreeSet<String>();
    TreeSet<String> t2 = new TreeSet<String>();
    TreeSet<String> t3 = new TreeSet<String>();
    TreeSet<Integer> num = new TreeSet<Integer>();

    public void Arr_1() {
        //Q-1 Write a Java program to create a tree set, add some colors (strings) and print out the tree set.
        t1.add("Red");
        t1.add("Green");
        t1.add("Blue");
        t1.add("Yellow");

        System.out.println(t1);
    }

    public void Arr_2() {
        //Q-2 Write a Java program to iterate through all elements in a tree set.
        for (String i : t1) {
            System.out.println(i);
        }
    }

    public void Arr_3() {
        t2.add("Black");
        t2.add("Blue");
        t2.add("Pink");
        t2.add("Yellow");

        //Q-3 Write a Java program to add all the elements of a specified tree set to another tree set.
        t1.addAll(t2);
        System.out.println(t1);
    }

    public void Arr_4(int index) {
        //Q-4 Write a Java program to create a reverse order view of the elements contained in a given tree set.
        System.out.println(t1.descendingSet());

    }

    public void Arr_5() {
        //Q-5 Write a Java program to get the first and last elements in a tree set.
        System.out.println(t1.first());
        System.out.println(t1.last());

    }

    public void Arr_6() {
        //Q-6 Write a Java program to clone a tree set list to another tree set.
        TreeSet<String> clo = (TreeSet<String>) t1.clone();
        System.out.println(clo);
    }

    public void Arr_7() {
        //Q-7 Write a Java program to get the number of elements in a tree set.
        System.out.println(t1.size());

    }

    public void Arr_8() {
        //Q-8. Write a Java program to compare two tree sets.
        System.out.println("First TreeSet :: " + t1);
        System.out.println("Second TreeSet :: " + t2);

        for (String ele : t1) {
            System.out.println(t2.contains(ele) ? "Yes" : "No");
        }
    }

    public void Arr_9() {
        num.add(5);
        num.add(10);
        num.add(9);
        num.add(20);
        num.add(4);
        num.add(2);

        //Q-9  Write a Java program to find numbers less than 7 in a tree set.
        TreeSet<Integer> tree_num = new TreeSet<Integer>();

        tree_num = (TreeSet) num.headSet(7);

        Iterator it = tree_num.iterator();

        System.out.println("Tree set data: ");
        while (it.hasNext()) {
            System.out.println(it.next() + " ");
        }
    }

    public void Arr_10() {
//Q-10 Write a Java program to get the element in a tree set which is greater than or equal to the given element.
        System.out.println("greter then or eq ceiling tree set: " + num.ceiling(7));

    }

    public void Arr_11() {
        //Q-11 Write a Java program to get the element in a tree set less than or equal to the given element.
        System.out.println("less then or eq floor tree set: " + num.floor(7));

    }

    public void Arr_12() {
        //Q-12 Write a Java program to get the element in a tree set strictly greater than or equal to the given element.
        System.out.println("Higher then tree set: " + num.higher(7));

    }

    public void Arr_13() {
        //Q-13 Write a Java program to get an element in a tree set that has a lower value than the given element.
        System.out.println("Lower then tree set: " + num.lower(7));

    }

    public void Arr_14() {
        //Q-14 Write a Java program to retrieve and remove the first element of a tree set.
        System.out.println(t1.pollFirst());
        System.out.println("first element Remove from treeset :: " + t1);

    }

    public void Arr_15() {
        //Q-15  Write a Java program to retrieve and remove the last element of a tree set.
        System.out.println(t1.pollLast());
        System.out.println("Last element Remove from treeset :: " + t1);

    }

    public void Arr_16() {
        //Q-16 Write a Java program to remove a given element from a tree set.
        System.out.println("Remove Pink element from treeset :: " + t1.remove("pink"));

    }

    public static void main(String[] args) {
        
        D arr = new D();
        arr.Arr_1();
        arr.Arr_2();
        arr.Arr_3();
        arr.Arr_4(4);
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

    }
}
