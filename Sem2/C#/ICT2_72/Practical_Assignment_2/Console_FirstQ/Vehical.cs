using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_FirstQ
{
    internal class Vehical
    {
        public int v_Id {  get; set; }
        public string v_Name { get; set; }

        public virtual void Vehical_Class()
        {
            Console.WriteLine("Vehical Class.." + v_Name + "\t");
        }


    }
}
