using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTupleDelegateOopsConcepts
{
    class MyClass
    {
        public static void showArray<Y>(Y[] arr)
        {
            foreach (var y in arr)
            {
                Console.WriteLine(y.ToString());
            }
        }

        public static bool check<T>(T a,T b)
        {
            bool c = a.Equals(b);
            return c;
        }
        public static void checkDatatype<T>(T a)
        {
            Console.WriteLine(typeof(T));
        }
    }
    class GenericExample
    {
        static void Main(string[] args)
        {
            MyClass.checkDatatype(2.5f);

            Console.WriteLine(MyClass.check(5,8));
            //Console.WriteLine(MyClass.check(8.5, 8));
            //Console.WriteLine(MyClass.check('G', 'A'));
            //Console.WriteLine(MyClass.check("hfh", "gfcg"));


            int[] number = new int[] { 1, 2, 3, 8, 8 };
            int[] index_numbs = new int[3];
            index_numbs[0] = number[0];
            index_numbs[1] = 6;
            index_numbs[2] = number[4];

            int[] direct_num = { 5, 1, 7, 6, 5 };

            string[] strs = new string[] { "cc", "dd", "ss", "uu" };

            double[] doubles = new double[] { 2.5, 8.8f, 2, 5.65 };

            MyClass.showArray(doubles);
        }
    }
}
