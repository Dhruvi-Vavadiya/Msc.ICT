using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_FirstQ
{
    internal class ElectricCar :Car
    {
        public int betteryLife {  get; set; }

       
        public override void Vehical_Class()
        {
            base.Vehical_Class();
            Console.WriteLine("elecricCar clas..:- "+betteryLife);
        }
    }
}
