using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleAppEventDelegte.ddDeclare;

namespace ConsoleAppEventDelegte
{
    internal class Program
    {
        public static void print() { Console.WriteLine("program class print() method throgh get myclass abcd method using VoidDelegate name delegate"); }
        static void Main(string[] args)
        {
            //DdMethods ddMethods = new DdMethods();

            //VoidDelegate voiddel = print;
            //DdMethods.ABCD(voiddel);

            Product product = new Product();
            product.productId = 1;
            product.productName = "Test";
            product.Qty = 5;
            product.rate = 5;

            product.minRequird = 5;
            product.maxCapacity = 20;

            Console.WriteLine(product);

            Console.WriteLine("===================================");
            product.sell = 5;
            Console.WriteLine(product);

            product.stock_Low += new Product.stockHandler(ProductManager.LowStock_event);

            Console.WriteLine("===================================");
            product.buy = 5;
            Console.WriteLine(product);




        }
    }
}
