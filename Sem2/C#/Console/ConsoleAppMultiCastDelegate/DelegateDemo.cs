using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMultiCastDelegate
{

    public delegate string GetDataValues();

    internal class DelegateDemo
    {
       
        public static string DataVal_1()
        {
            return "this is data value 1";
        }
        public static string DataVal_2()
        {
            return "this is data value 2";
        }
    }
}
