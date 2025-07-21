using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleAppEventDelegte.ddDeclare;

namespace ConsoleAppEventDelegte
{
    internal class DdMethods
    {
        public static void ABCD(VoidDelegate del)
        {
            //Program.print(); //Problem
            del();
        }
        //VoidDelegate
        public static void print() { Console.WriteLine("program class print() method throgh get myclass abcd method using VoidDelegate name delegate"); }

        //VoidDelWithParameter
        private static void display(string msg) { Console.WriteLine("display method :-" + msg); }

    }
}
