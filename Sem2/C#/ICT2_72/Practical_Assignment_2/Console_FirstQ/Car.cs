using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_FirstQ
{
    internal class Car : Vehical
    {
        public int c_id {  get; set; }
        public string c_Model { get; set; }

       public string c_color { get; set; } 
       

        
        public override void Vehical_Class()
        {
            base.Vehical_Class();
            Console.WriteLine("car class.. "+c_color);
        }
    }
}
