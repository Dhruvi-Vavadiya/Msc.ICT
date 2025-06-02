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

                        Console.WriteLine($"index[{index}] : {value} ==> Value is invalid");
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
            emp[0, 1] = 20;

            emp[1] = 100;
            emp[5] = -55; //else minuse value not allowd
            emp[9] = 65; //else index unbound value
            Console.WriteLine(emp[0]);
            
        }
    }
}
