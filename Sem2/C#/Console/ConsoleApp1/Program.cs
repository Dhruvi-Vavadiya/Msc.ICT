
// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

public class Program
{
    public static void Main()
    {

       
            Complex num1 = new Complex(2, 3);
            Complex num2 = new Complex(4, 5);

            Complex result = num1 * num2;  // Using overloaded +

            result.Display();   
        
        Console.WriteLine("Hello, mahadev!");

        StudnetCollection<int> dataColl = new StudnetCollection<int>();

        dataColl.AddList(1554);
        dataColl.AddList(29859);
        dataColl.AddList(3848);

        dataColl.AddList(86565);

        dataColl.Show();

        Console.WriteLine("========");

        StudnetCollection<Student> studentCollection = new StudnetCollection<Student>();
        studentCollection.AddList(new Student() { id = 1, name = "ABC", age = 20 });
        studentCollection.AddList(new Student() { id = 2, name = "XYZ", age = 22 });
        studentCollection.AddList(new Student() { id = 3, name = "PQR", age = 24 });

        //studentCollection.Show();

        Console.WriteLine("========");
        StudnetCollection<int> myint = new StudnetCollection<int>();
        StudnetCollection<int> myint1 = new StudnetCollection<int>();

        Console.WriteLine(studentCollection.Count);
        Console.WriteLine(dataColl.Count);

       

        ///


    }
}