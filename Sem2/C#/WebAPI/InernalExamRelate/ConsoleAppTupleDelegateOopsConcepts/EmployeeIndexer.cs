using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTupleDelegateOopsConcepts
{
    public class EmpAgeIndxer
    {
        private int[] Age = new int[7];
        private int[] Birth = new int[7];

        public int this[int index]
        {
            set
            {
                if (index >= 0 && index < Age.Length)
                {
                    if (value > 0)
                    {
                        Age[index] = value;
                    }
                    else
                    {

                        Console.WriteLine($"index[{index}] : {value} ==> Value is not invalid");
                        Age[index] = 500;
                    }
                }
                else
                {
                    Console.WriteLine("index value invalid");
                }
            }

            get
            {
                return Age[index];
            }

        }
        

        public int this[int index, int i]
        {
            get
            {
                return Age[index];
            }
            set
            {
                Age[index] = value + i ;
            }
        }
    }
    class EmployeeIndexer
    {
        public static void Main(string[] args)
        {
            EmpAgeIndxer emp = new EmpAgeIndxer();
            emp[1, 1] = 20;

            emp[1] = 100;
            emp[5] = -55; //else minuse value not allowd
            emp[9] = 65; //else index unbound value
            Console.WriteLine(emp[0]);

            chkPalindrome("dhrhd");


            void chkPalindrome(string str)
            {
                bool flag = false;
                for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
                {
                    if (str[i] != str[j])
                    {
                        flag = false;
                        break;
                    }
                    else
                        flag = true;
                }
                if (flag)
                {
                    Console.WriteLine("Palindrome");
                }
                else
                    Console.WriteLine("Not Palindrome");

            }
                //-------------------------------------------------
                if (FindPrime(15))
                {
                    Console.WriteLine("Prime");
                }
                else
                {
                    Console.WriteLine("Not Prime");
                }
                Console.ReadLine();
            
 bool FindPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
                int n = number % 2;
            if (number % 2 == 0) return false;
                var sq = Math.Sqrt(number);
                var fl = Math.Floor(sq);
            var squareRoot = (int)Math.Floor(Math.Sqrt(number));
            for (int i = 3; i <= squareRoot; i += 2)
            {
                    int dd = i;
                if (number % i == 0) return false;
            }
            return true;
        }
    }
    }
}



//---------------------------------------------------------------/


// static void Main(string[] args)
//{
//    if (FindPrime(47))
//    {
//        Console.WriteLine("Prime");
//    }
//    else
//    {
//        Console.WriteLine("Not Prime");
//    }
//    Console.ReadLine();
//}
//internal static bool FindPrime(int number)
//{
//    if (number == 1) return false;
//    if (number == 2) return true;
//    if (number % 2 == 0) return false;
//    var squareRoot = (int)Math.Floor(Math.Sqrt(number));
//    for (int i = 3; i <= squareRoot; i += 2)
//    {
//        if (number % i == 0) return false;
//    }
//    return true;
//}