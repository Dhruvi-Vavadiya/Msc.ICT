using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsTutorialPoint
{
    internal class Program
    {
        int marks;
        static int maxmaks = 50;


        Program()
        {
            this.marks = 10;
        }
        Program(int ma)
        {
            this.marks = ma;
        }
        Program(Program p)
        {
            this.marks = p.marks;
        }

        void Calcu()
        {
            int perce = marks + maxmaks;
            Console.WriteLine(perce);
        }
        //object in
        int age;
        string name;
        char gender;
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.Calcu();

            Program program = new Program(20);
            program.Calcu();

            //copy cons
            
            Program p2 = new Program(program);
            p2.Calcu();

            Program copyprofam = program;
            program.marks = 80; //chnage value in program object
            copyprofam.Calcu();

            //object in


            Program obj1 = new Program { age = 25, name = "dheufi", gender = 'M'};

         

        }
    }
}
