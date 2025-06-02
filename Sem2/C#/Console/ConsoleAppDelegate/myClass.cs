using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleAppDelegate.Program;

namespace ConsoleAppDelegate
{
    internal class myClass
    {
        public static void MyClassCalCulateMethod(CalculateDelegate del)
        {
            Console.WriteLine(del(5, 2));
        }
        public static void ABCD(VoidDelWithParameter del)
        {

            del("Hello");
        }

        public static void ABCD(VoidDelegate del)
        {
            //Program.print(); //Problem
            del();
        }
    }
}
