using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExampleEvent
{
    internal class Program
    {
        public void ChangeOfValue()
        {
            Console.WriteLine("Handler Called and value is changed.");
        }
        static void Main(string[] args)
        {
            // Call constructor with intial value: 3

            EventTestClass etc = new EventTestClass(3);

            Program app = new Program();

            // Create a handler for this class

            etc.Changedevent += new
            EventTestClass.ValueChangedEventHandler(app.ChangeOfValue);

            etc.SetValue(3);

            etc.SetValue(5);

            //====================
            EventPublisher publisher = new EventPublisher();
            Subscriber subscriber = new Subscriber();

            // Step 6: Subscribe to the event
            publisher.OnNotify += subscriber.ShowMessage;

            // Trigger the event
            publisher.TriggerEvent();
        }
        //=========End main method==========
        // Step 1: Declare a delegate
        public delegate void NotifyEventHandler();

        // Step 2: Create a class that contains the event
        class EventPublisher
        {
            // Step 3: Declare an event using the delegate
            public event NotifyEventHandler OnNotify;

            public void TriggerEvent()
            {
                Console.WriteLine("Event is about to be triggered...");

                // Step 4: Raise the event (only if there are subscribers)
                //OnNotify?.Invoke();
                if (OnNotify != null)
                {
                    OnNotify();  // Call the event if there are subscribers
                }

            }
        }

        class Subscriber
        {
            // Step 5: Event handler method
            public void ShowMessage()
            {
                Console.WriteLine("Event received! Handling event...");
            }
        }




    }
}
