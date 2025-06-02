//ArrayList

import java.util.*;

public class A {

    ArrayList<String> color = new ArrayList<String>();

    public void Arr_1() {

        color.add("Red");
        color.add("Green");
        color.add("Blue");
        color.add("Yellow");
        color.add("White");

        //Q-1  Write a Java program to create an array list, add some colors (strings) and print out the collection.
        System.out.println("Display all array element ::");
        System.out.println(color);
    }

    public void Arr_2() {
        //Q-2  Write a Java program to iterate through all elements in an array list.
        System.out.println("For Each Loop ::");
        for (String c : color) {
            System.out.println(c);
        }
    }

    public void Arr_3() {

        //Q-3  Write a Java program to insert an element into the array list at the first position.
        System.out.println("Add Pink color at first position ::");
        color.add(0, "Pink");
        System.out.println(color);
    }

    public void Arr_4(int index) {

        //Q-4  Write a Java program to retrieve an element (at a specified index) from a given array list.
        System.out.println("retrive third element ::");
        System.out.println(color.get(index));
    }

    public void Arr_5() {

        //Q-5  Write a Java program to update an array element by the given element.
        System.out.println("chnage third postion of array element ::");
        color.set(2, "Black");
        System.out.println(color);
    }

    public void Arr_6() {

        //Q-6 Write a Java program to remove the third element from an array list.
        System.out.println("remove second potion of element ::");
        color.remove(1);
        System.out.println(color);
    }

    public void Arr_7() {

        //Q-7 Write a Java program to search for an element in an array list.
        System.out.println("search for an element in arrayList::"+color.contains("Pink"));

    }

    public void Arr_8() {

        //Q-8 Write a Java program to sort a given array list.
        System.out.println("Sort arrayList ::");
        Collections.sort(color);
        System.out.println(color);
    }

    public void Arr_9() {

        //Q-9 Write a Java program to copy one array list into another.
        System.out.println("Copy arryList ::");
        ArrayList<String> color1 = (ArrayList<String>) color.clone();
        System.out.println("Color arrayList ::");
        System.out.println(color);
        System.out.println("Color1 arrayList ::");
        System.out.println(color1);
    }

    public void Arr_10() {

        //Q-10 Write a Java program to shuffle elements in an array list.
        System.out.println("Shuffle arrayList ::");
        Collections.shuffle(color);
        System.out.println(color);
    }

    public void Arr_11() {

        //Q-11 Write a Java program to reverse elements in an array list.
        System.out.println("Reverse Element ::");

        ListIterator<String> it = color.listIterator();
        while (it.hasNext()) {
            System.out.println(it.next());
        }
        System.out.println("========================");
        while (it.hasPrevious()) {
            System.out.println(it.previous());
        }
    }

    public void Arr_12() {

        //Q-12 Write a Java program to extract a portion of an array list.
        System.out.println("Sublist ::");
        System.out.println(color.subList(1, 4));
    }

    public void Arr_13() {

        //Q-13 Write a Java program to compare two array lists.
        System.out.println("Compare arrayList ::");
        ArrayList<String> color2 = new ArrayList<String>();

        color2.add("Purpul");
        color2.add("Green");
        color2.add("Yellow");
        color2.add("White");
        // System.out.println(color);
        // System.out.println(color2);
        for (String c : color) {
            if (color2.contains(c)) {
                System.out.println(c + " is present in both arrayList");
            }
        }
    }

    public void Arr_14() {

        //Q-14 Write a Java program that swaps two elements in an array list.
        System.out.println("Swap two elements from arrayList ::");

        Collections.swap(color, 0, 2);
        System.out.println(color);

    }

    public void Arr_15() {

        //Q-15 Write a Java program to join two array lists.
        ArrayList<String> car = new ArrayList<String>();
        car.add("BMW");
        car.add("Audi");
        car.add("Toyota");
        car.add("Honda");

        System.out.println("Mearged two arrayList ::");

        ArrayList<String> car1 = new ArrayList<String>();
        car1.addAll(color);
        car1.addAll(car);

        System.out.println(car1);
    }

    public void Arr_16() {

        //Q-16 Write a Java program to clone an array list to another array list.
        System.out.println("clone an array list another array list ::");

        ArrayList<String> clone = (ArrayList<String>) color.clone();
        System.out.println(clone);

    }

    public void Arr_17() {

        ArrayList<String> car = new ArrayList<String>();
        car.add("BMW");
        car.add("Audi");
        car.add("Toyota");
        car.add("Honda");

        //Q-17 Write a Java program to empty an array list.
        System.out.println(" empty an array list ::");

        car.removeAll(car);
        System.out.println(car);

    }

    public void Arr_18() {
        ArrayList<String> car = new ArrayList<String>();
        car.add("BMW");
        car.add("Audi");
        car.add("Toyota");
        car.add("Honda");

        //Q-18 Write a Java program to test whether an array list is empty or not.
        System.out.println("Check arrayList is empty or not ::");
        if (car.isEmpty()) {
            System.out.println("Array List is empty");
        } else {
            System.out.println(car);
            System.out.println("Array List is not empty");
        }
    }

    public void Arr_19() {

        //Q-19 Write a Java program for trimming the capacity of an array list.
        System.out.println("Trimimg arrayList ::");
        color.trimToSize();
        System.out.println(color);
    }

    public void Arr_20() {

        //Q-20 Write a Java program to increase an array list size.
        System.out.println("Capacity of arrayList ::");

        color.ensureCapacity(7);
        color.add("abc");
        color.add("xyz");

        System.err.println(color);
    }

    public void Arr_21() {

        //Q-21 Write a Java program to replace the second element of an ArrayList with the specified element.
        System.out.println("Replace arry element of arrayList ::");

        System.out.println(color);
        color.set(1, "Black");
        System.out.println(color);
    }

    public void Arr_22() {

        //Q-22 Write a Java program to print all the elements of an ArrayList using the elements position.
        System.out.println("ArrayList using the position of the elements");

        for (int i = 0; i < color.size(); i++) {
            System.out.println(color.get(i));
        }
    }

    public static void main(String[] args) {
        // Scanner sc=new Scanner(System.in);

        A arr = new A();
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
        arr.Arr_17();
        arr.Arr_18();
        arr.Arr_19();
        arr.Arr_20();
        arr.Arr_21();
        arr.Arr_22();

    }
}
