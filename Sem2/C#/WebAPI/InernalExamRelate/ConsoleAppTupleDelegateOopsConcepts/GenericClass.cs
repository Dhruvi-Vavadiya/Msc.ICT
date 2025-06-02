using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTupleDelegateOopsConcepts
{
    public class Exmaple<T>
    {
        T box;

        //public Exmaple(T b)
        //{
        //    this.box = b;
        //}

        //public T getBox()
        //{
        //    return this.box;
        //}

        //prorperties

        public T Box
        {
            get
            {
                return this.box;
            }
            set
            {
                this.box = value;
            }
        }


    }
    internal class GenericClass
    {

        static void Main()
        {
            //Exmaple<string> exmaple = new Exmaple<string>("dhry");
            //Console.WriteLine(exmaple.getBox());

            //Exmaple<int> exmaple1 = new Exmaple<int>(65);
            //Console.WriteLine(exmaple1.getBox());

            //properies

            Exmaple<int> e = new Exmaple<int>();
            e.Box = 55;
            Console.WriteLine(e.Box);


            /// generic example collage example
            /// 
           

        }
    }
}
