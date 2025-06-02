using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLog4Net
{
    public class AssemblyOne
    {
        internal string Display()
        {
            Console.WriteLine("Internal method called.");
            return "Internal method called.";
        }
        protected internal string ShowMessage()
        {
            Console.WriteLine("Protected Internal method called.");
            return "Protected Internal method called.";
        }
    }
}
