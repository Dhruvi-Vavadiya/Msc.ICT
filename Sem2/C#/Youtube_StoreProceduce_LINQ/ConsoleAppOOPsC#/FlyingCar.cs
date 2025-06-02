using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPsC_
{
    internal class FlyingCar : IFlyable, IDriveable
    {
        public void Drive()
        {
            Console.WriteLine("Driving on the road...");
        }

        public void Fly()
        {
            Console.WriteLine("Flying in the sky...");
        }

      public void Speak() => Console.WriteLine("Woof! Woof!");
    }
}
