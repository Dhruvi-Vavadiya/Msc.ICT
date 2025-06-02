using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMultiCastDelegate
{

    public delegate string UpdateMyData(int a, int b);

    internal class CallBackMethod
    {
        public int val_1;
        public int val_2;

        public UpdateMyData UpdatemydataMethod;

        // prperties
        public UpdateMyData CallUpdateData
        {
            set
            {
                UpdatemydataMethod = value;
            }
            get
            {
                return UpdatemydataMethod;
            }
        }


        public void GetResult()
        {
            if (UpdatemydataMethod != null)
            {
                Console.WriteLine(UpdatemydataMethod(val_1, val_2));
            } else
                Console.WriteLine("no result");
        }
    }
}
