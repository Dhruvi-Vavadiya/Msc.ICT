import java.util.LinkedList;

public class First {

    public static void main(String[] args) {
        LinkedList<String> list = new LinkedList<String>();

        list.add("Pinepal");
        list.add("apple");
        list.add("banana");

        

        // list.addFirst("Mango");

        // list.addLast("barry");

        // list.removeFirst();

        // list.removeLast();

        // list.getFirst();

        LinkedList<String> car = new LinkedList<String>();

        car.addAll(list);

        LinkedList<String> car2=(LinkedList<String>)list.clone();
        car2.set(0,"sdc");
        System.out.println(car);
        System.out.println(car2);

        

    }

}
