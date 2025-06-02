using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEventDelegte
{
    internal class EventTestClass
    {
        // The value to track

        private int nValue;

        // Create a handler for the event (delegate)

        public delegate void ValueChangedEventHandler();

        // Create the event

        public event ValueChangedEventHandler Changed;

        // Create a method to fire the event

        protected virtual void OnChanged()

        {

            if (Changed != null)

                Changed();

            else

                Console.WriteLine("Event fired. No handler!");

        }

        //Constructure

        public EventTestClass(int nValue)

        {

            SetValue(nValue);

        }

        //Method to check the value and fire the event if require.

        public void SetValue(int nV)

        {

            if (nValue != nV)

            {

                nValue = nV;

                // Fire the event

                OnChanged();

            }

        }
    }
}
