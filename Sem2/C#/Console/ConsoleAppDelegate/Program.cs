using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleAppDelegate.Program;

namespace ConsoleAppDelegate
{
    internal class Program
    {
        public delegate void VoidDelegate();

        public delegate void VoidDelWithParameter(string msg);

        public delegate int CalculateDelegate(int a, int b);

        //multiple delegate
        public delegate void show_del();

        public delegate void cal_del_2(int num);

        // ================  methods  ====================

        public static void Square(int num)
        {
            int sq = num * num;
            Console.WriteLine("Square of {0} is {1} ",num,sq);
        }

        public static void Cube(int num)
        {
            int cu = num * num * num;
            Console.WriteLine("Cube of {0} is {1} ", num, cu);
        }
        public static void factorial(int num)
        {
            int fact = 1;
            for (int i = 1; i <= num; i++) { 
                fact *= i;
            }
            Console.WriteLine("factorial of {0} is {1} ", num, fact);
        }
        public static void show_method(){Console.WriteLine("i am show method!!!!");}

        public static int add(int x, int y){return x + y;}
        public static int subt(int x, int y){return x - y;}
        private static void print(){Console.WriteLine("program class print() method throgh get myclass abcd method using VoidDelegate name delegate");}
        private static void display(string msg){Console.WriteLine("display method :-" + msg);}

        //=====================(main mthod)==============================
        public static void Main(string[] args)
        {
            //print();

            VoidDelegate del1 = print;
            //del1 += display;
             myClass.ABCD(del1);

            VoidDelWithParameter del2 = display;
            myClass.ABCD(del2);

            CalculateDelegate del3 = subt;       //add;
            //Console.WriteLine(del3.Invoke(5, 3));
            myClass.MyClassCalCulateMethod(del3);


            //multiple delegate refrence to point show mthod
            show_del obj = new show_del(show_method);
            obj.Invoke();

            // multiple
            cal_del_2 cal2 = new cal_del_2(Square);
            cal2.Invoke(2); //cal2(2); //2 option

            //cal2 = Cube;
            //cal2.Invoke(3);

            //multicast

            cal_del_2 objmulticast = new cal_del_2(Square);
            objmulticast += Cube;
            objmulticast += factorial;
            objmulticast(3);
        }

    }
    //program class end

    //new class
    //Start myclass

    //internal class myClass
    //{
    //    public static void MyClassCalCulateMethod(CalculateDelegate del)
    //    {
    //        Console.WriteLine(del(5, 2));
    //    }
    //    public static void ABCD(VoidDelWithParameter del)
    //    {

    //        del("Hello");
    //    }

    //    public static void ABCD(VoidDelegate del)
    //    {
    //        //Program.print(); //Problem
    //        del();
    //    }
    //}

    //end myclass
}
