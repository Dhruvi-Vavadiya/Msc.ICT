using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEventDelegte
{
    internal class EventDemoClass
    {
        public void ChangeOfValue()

        {

            Console.WriteLine("Handler Called and value is changed.");

        }

        public static void Main()

        {

            // Call constructor with intial value: 3

            EventTestClass etc = new EventTestClass(3);

            EventDemoClass app = new EventDemoClass();

            // Create a handler for this class

            etc.Changed += new
            EventTestClass.ValueChangedEventHandler(app.ChangeOfValue);

            etc.SetValue(3);

            etc.SetValue(5);

            Console.ReadLine();
        }
        }
}
