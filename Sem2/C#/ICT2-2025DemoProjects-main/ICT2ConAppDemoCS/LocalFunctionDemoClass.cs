using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT2ConAppDemoCS
{
    public class LocalFunctionDemoClass
    {
        private int x;
        public int y;
        public int X
        {
            set
            {
                x = value * 2;
            }
        }
    
        public void GetUpdatedData()
        {
            int z = 20;

            Console.WriteLine("Value of x is " + x);
            Console.WriteLine("Value of y is " + y);

            x = GetUpdatedX(x);
            y = GetUpdatedY(y);
            
            Console.WriteLine("Updated Value of x is {0} and y is {1} ", x, y);
            
            int GetUpdatedY(int y)
            {
                return y * 20 + z;
            }
            
        }

        int GetUpdatedX(int x)
        {
            return x + y * 2;
        }
        

        public static void Main(string[] args)
        {
            LocalFunctionDemoClass ld = new LocalFunctionDemoClass();
            ld.GetUpdatedData();
        }
    }
}
