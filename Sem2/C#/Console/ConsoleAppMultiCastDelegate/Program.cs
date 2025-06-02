using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMultiCastDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetDataValues g = new GetDataValues(DelegateDemo.DataVal_1);
            //g += new GetDataValues(DelegateDemo.DataVal_2);

            Console.WriteLine(g());
           g += DelegateDemo.DataVal_2;
           Console.WriteLine(g());

            //===========================================================

            //is class
            CallBackMethod callb = new CallBackMethod();

            callb.val_1 = 10;
            callb.val_2 = 20;

            callb.CallUpdateData = new UpdateMyData(CallbackFunc.showValue);
            //callb.CallUpdateData += new UpdateMyData(CallbackFunc.updateValue);

            callb.GetResult();

        }
    }
}
