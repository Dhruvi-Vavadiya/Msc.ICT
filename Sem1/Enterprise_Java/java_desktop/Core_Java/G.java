//TreeMap   

import java.util.Comparator;
import java.util.Map;
import java.util.TreeMap;
import java.util.Map.Entry;

public class G {

    TreeMap<String, Integer> t1 = new TreeMap<String, Integer>();
    TreeMap<String, Integer> t2 = new TreeMap<String, Integer>();
    TreeMap<Integer, String> num = new TreeMap<Integer, String>();

    public void Arr_1() {
        //Q-1. Write a Java program to associate the specified value with the specified key in a Tree Map.
        t1.put("Red", 10);
        t1.put("Green", 20);
        t1.put("Blue", 30);
        t1.put("Yellow", 40);
        System.out.println(t1);
    }

    public void Arr_2() {
        //Q-2. Write a Java program to copy Tree Map&#39;s content to another Tree Map.
        t2.put("Black", 10);
        t2.put("Blue", 20);
        t2.put("Pink", 30);

        t2.putAll(t1);

        System.out.println(t2);
    }

    public void Arr_3() {
        //Q-3. Write a Java program to search for a key in a Tree Map.
        System.out.println("t1 TreeMap :: " + t1);

        if (t1.containsKey("Red")) {

            System.out.println("Yes ::" + t1.get("Red"));
        } else {

            System.out.println("No");
        }
        if (t1.containsKey("Pink")) {

            System.out.println("Yes");
        } else {

            System.out.println("No");
        }
    }

    public void Arr_4() {
        //Q-4. Write a Java program to search for a value in a Tree Map.
        if (t1.containsValue(30)) {

            System.out.println("Yes,30 value pair is present");
        } else {

            System.out.println("No");
        }
        if (t1.containsValue(50)) {

            System.out.println("Yes");
        } else {

            System.out.println("No,50 value pair is not present");
        }

    }

    public void Arr_5() {
        //Q-5. Write a Java program to get all keys from a Tree Map.
        System.out.println(t1.keySet());
    }

    public void Arr_6() {
        //Q-6. Write a Java program to delete all elements from a Tree Map.
        //  t1.clear();
        System.out.println("clear ele ::" + t1);

    }

    public void Arr_7() {
        System.out.println("==================");
        //Q-7. Write a Java program to sort keys in a Tree Map by using a comparator.
        TreeMap<String, String> t3 = new TreeMap<String, String>(new sort_key());
        t3.put("C2", "Red");
        t3.put("C4", "Green");
        t3.put("C3", "Black");
        t3.put("C1", "White");
        System.out.println(t3);

    }

    class sort_key implements Comparator<String> {

        @Override
        public int compare(String str1, String str2) {
            return str1.compareTo(str2);
        }

    }

    public void Arr_8() {
        //Q-8. Write a Java program to get a key-value mapping associated with the greatest key and the least key in a map.
        System.out.println("First TreeMap :: " + t1.firstEntry());
        System.out.println("Second TreeMap :: " + t1.lastEntry());
    }

    public void Arr_9() {
        //Q-9. Write a Java program to get the first (lowest) key and the last (highest) key currently in a map.
        System.out.println("First TreeMap :: " + t1.firstKey());
        System.out.println("Last TreeMap :: " + t1.lastKey());
    }

    public void Arr_10() {
        //Q-10. Write a Java program to get a reverse order view of the keys contained in a given map.
        System.out.println(t1.descendingKeySet());
    }

    public void Arr_11() {
        //Q-11. Write a Java program to get a key-value mapping associated with the greatest key less than or equal to the given key.
        num.put(10, "A");
        num.put(80, "B");
        num.put(30, "C");
        num.put(60, "D");
        num.put(50, "E");
        System.out.println("===========11===============");
        System.out.println(num.floorEntry(40));
        System.out.println(num.floorEntry(70));
        System.out.println(num.floorEntry(110).getValue());
    }

    public void Arr_12() {
        //Q-12. Write a Java program to get the greatest key less than or equal to the given key.
        System.out.println("=============12=============");
        System.out.println(num.floorKey(40));
        System.out.println(num.floorKey(70));
        System.out.println(num.floorKey(110));
    }

    public void Arr_13() {
        System.out.println("==========================");
        //Q-13. Write a Java program to get the portion of a map whose keys are strictly less than a given key.
        System.out.println(num.headMap(40));
        System.out.println(num.headMap(70));
        System.out.println(num.headMap(110));

    }

    public void Arr_14() {
        System.out.println("=============14=============");
        //Q-14. Write a Java program to get the portion of this map whose keys are less than (or equal to, if inclusive is true) a given key.
        System.out.println(num.headMap(40, true));
        System.out.println(num.headMap(70, false));
        System.out.println(num.headMap(110, true));

    }

    public void Arr_15() {
        System.out.println("==========================");
        //Q-15. Write a Java program to get the least key strictly greater than the given key. Return null if there is no such key.
        System.out.println(num.higherEntry(40));
        System.out.println(num.higherEntry(70));

    }

    public void Arr_16() {
        System.out.println("===========16===============");
        //Q-16. Write a Java program to get a key-value mapping associated with the greatest key strictly less than the given key. Return null if there is no such key.
        System.out.println(num.lowerEntry(40));
        System.out.println(num.lowerEntry(70));

    }

    public void Arr_17() {
        System.out.println("==========================");
        //Q-17. Write a Java program to get the greatest key strictly less than the given key. Return null if there is no such key.
        System.out.println(num.lowerKey(10));
        System.out.println(num.lowerKey(70));
    }

    public void Arr_18() {
        System.out.println("==========================");
        //Q-18. Write a Java program to get a NavigableSet view of keys in a map.
        System.out.println(num.navigableKeySet());
    }

    public void Arr_19() {
        System.out.println("=============19=============");
        //Q-19. Write a Java program to remove and get a key-value mapping associated with the least key in a map.
        System.out.println(t1.pollFirstEntry());
        System.out.println(t1);
    }

    public void Arr_20() {
        System.out.println("==========================");
        //Q-20. Write a Java program to remove and get a key-value mapping associated with the greatest key in this map.
        System.out.println(t1.pollLastEntry());
        System.out.println(t1);
    }

    public void Arr_21() {
        System.out.println("==============21============");
        //Q-21. Write a Java program to get the portion of a map whose keys range from a given key (inclusive) to another key (exclusive).
        System.out.println(num.subMap(40, 70));

    }

    public void Arr_22() {
        System.out.println("==========================");
        //Q-22. Write a Java program to get the portion of a map whose keys range from a given key to another key.
        System.out.println(num.subMap(40, true, 70, false));
    }

    public void Arr_23() {
        System.out.println("============23==============");
        //Q-23. Write a Java program to get a portion of a map whose keys are greater than or equal to a given key.
        System.out.println(num.tailMap(40));
    }

    public void Arr_24() {
        //Q-24. Write a Java program to get a portion of a map whose keys are greater than a given key.
        System.err.println("=========================");
        System.out.println(num);
        System.out.println(num.tailMap(40, false));

    }

    public void Arr_25() {
        System.out.println("=============25=============");
        //Q-25. Write a Java program to get a key-value mapping associated with the least key greater than or equal to the given key. Return null if there is no such key.
        System.out.println(num.ceilingEntry(40));
        System.out.println(num.ceilingEntry(70));
    }

    public void Arr_26() {
        System.out.println("==========================");
        //Q-26. Write a Java program to get the least key greater than or equal to the given key Returns null if there is no such key.
        System.out.println(num.ceilingKey(40));
        System.out.println(num.ceilingKey(70));
    }

    public static void main(String[] args) {
        G arr = new G();
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
        arr.Arr_20();
        arr.Arr_21();
        arr.Arr_22();
        arr.Arr_23();
        arr.Arr_24();
        arr.Arr_25();
        arr.Arr_26();
    }
}
