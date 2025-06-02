class Student{
    int roll;
    String nm;

    public Student(int roll,String nm){
        this.roll=roll;
        this.nm=nm;
    }
    public String toString(){
        return "Roll :"+roll+"\nName :"+nm;
    } 
}
public class ToStr {
    public static void main(String[] args) {
        Student s=new Student(101,"Raj");

        System.out.println(s);
    }
}
