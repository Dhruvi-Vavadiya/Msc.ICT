using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMultiCastDelegate
{
    internal class CallbackFunc
    {
        public static string showValue(int x ,int y)
        {
            return "your value :-" + (x + y);
        }
        public static string updateValue(int x, int y)
        {
            return "your updated value :-" + (x * y);
        }
    }
}
