using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppTupleDelegateOopsConcepts
{
    class Product
    {
       
        public string Color { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Size { get; set; }

        
    }

    class expressionbodie
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public expressionbodie(string name, int price)
        {
            Price = price;
            Name = name;

        }
        ~expressionbodie()
        {
            Console.WriteLine("expressionbodie's finalizer is called.");
        }
        public override string ToString() => $"{Price} {Name}".TrimEnd(',');
        public void displayrecord() => Console.WriteLine(ToString());


    }

    public class Location
    {
        private string locationName;

        public Location(string name)
        {
            locationName = name;
        }

        public string Name => locationName;

        //properties

        //public Location(string name) => Namee = name;

        public string Namee
        {
            get => locationName;
            set => locationName = value;
        }
    }
    internal class Program
    {


        static void Main(string[] args)
        {
            /////////////////////////////
            ///    expression bodies ==> aero operatoer use
            ////////////////////////////

            //Read - only properties //Location class
            //PropertyType PropertyName => expression;

            Location loca = new Location("Location");
            

            //syntax method
            //member => expression;

            expressionbodie p3 = new expressionbodie("dhrucu",5000);
            Console.WriteLine(p3.ToString());
            Console.WriteLine(p3);
            p3.displayrecord();

            

            /////////////////////////////
            ///    anonymous type menas new
            ////////////////////////////


            //this is not working
            //var apple = new { Item = "apples", Price = 1.35 };
            //var onSale = apple with { Price = 0.79 };
            //Console.WriteLine(apple);
            //Console.WriteLine(onSale);


            List<Product> product = new List<Product>();

            product.Add(new Product
            {
                Color = "red",
                Price = 26,
                Name = "dhruv",
                Category = "red",
                Size = "xxl",
            });
            


            var product_Query = from p in product select new { p.Color, p.Price,p.Name };

            foreach (var v1 in product_Query)
            {
                Console.WriteLine("Color={0}, Price={1}, Name={2}", v1.Color, v1.Price,v1.Name);
            }


            var v = new { Amount = 108, Message = "Hello" };
            Console.WriteLine(v.Amount);


            ////////////////////
            ///    dictionary linq query
            /////////////////////
            var numbers = new Dictionary<int, string>
            {
                [7] = "seven",
                [9] = "nine",
                [13] = "thirteen"
            };
            Console.WriteLine("Enter name or number:-");
            string num = Console.ReadLine();
            //search by key int 
            if (int.TryParse(num, out int num1))
            {
                var number = from i in numbers where i.Key == num1 select i;
                foreach (var item in number)
                {
                    Console.WriteLine(item.Key + " : " + item.Value);
                }
            }

            //search by name value
            var number1 = from i in numbers where i.Value == num select i;
            foreach (var item in number1)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }

        }
    }
}
