using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLINQEXAM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new String[] { "jatin", "mahesh", "puja", "dhruvi", "priyanka" };

            var newName = from n in names where n.ToLower().Contains("a") select n;

            //var newName = names.Where(n=>n.Contains("i")).Where(m=>m.Contains("d")).ToList();

            //var ame=from d in names select d.Length; //LINQ

            var ame = names.Select(s => s.Length).ToArray(); //Lemda

            foreach (string i in newName)
            {
                Console.WriteLine(i);
            }
            foreach(int i in ame)
            {
                Console.WriteLine(i);
            }

            int[] num = new int[] { 1,2,3, 4,5 };
            var nummresult = from n in num where n>=2 select n;
            Console.WriteLine("--------------");
            foreach (int i in nummresult)
            {
                Console.WriteLine(i);
            }

            //continoue in CSharp project
           
        }
    }
}
