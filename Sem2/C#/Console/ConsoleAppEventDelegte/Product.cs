using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEventDelegte
{
    internal class Product
    {
        public delegate string stockHandler();
        public event stockHandler stock_Low;
        public event stockHandler stock_high;
        //public event stockHandler handler;
        public int productId { get; set; }
        public string productName { get; set; }
        public int Qty { get; set; }
        public int rate { get; set; }

        public int stock_Amount
        {
            get { return Qty * rate; }
        }

        public int minRequird { get; set; }
        public int maxCapacity { get; set; }

        public int sell
        {
            set
            {
                if (Qty - value >= 0)
                {
                    Qty -= value;
                    checkStock_sale();
                }
            }
        }
        private void checkStock_sale()
        {
            if (Qty < minRequird)
            {
                Console.WriteLine("Event execute");
                if (stock_Low != null)
                {
                    Console.WriteLine(stock_Low());
                }
                else { }
            }
        }
        public int buy
        {
            set
            {
                if (checkstock_purchse(value)){
                    Qty += value;
                }
                else
                {
                    throw new InvalidOperationException("Insufficient stock available for purchase.");
                }
            }
        }
        private bool checkstock_purchse(int pur_qty)
        {
            bool isApproved = true;

            if (Qty > maxCapacity)
            {
                isApproved = false;
                if (stock_high != null)
                {
                    Console.WriteLine(stock_high());
                }
            }
            return isApproved;
        }



        public override string ToString()
        {
            return "ProductId :- " + productId + "\tproduct name :- " + productName + "\tQty :- " + Qty + "\tRate :-" + rate + "\tstock amount :- " + stock_Amount;
        }





    }
}
