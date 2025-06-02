using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ConsoleStringIndexer;

namespace ConsoleStudentApp
{
    internal class StudnetCollection
    {
        public students[] stud = new students[5];

        public students this[int index]
        {
            get
            {
                return stud[index];
            }
            set
            {
                stud[index] = value;
            }
        }


        public students this[string sName]
        {
            get
            {
                students response = null;
                for (int i = 0; i < 3; i++)
                {
                    if (stud[i].name.Equals(sName))
                    {
                        response = stud[i];
                        break;
                    }
                }
                return response;
            }
        }
    }
}


//ProductCollection.cs
//using System;
//using System.Collections.Generic; using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleStringIndexer
//{
//    internal class ProductCollection
//    {
//        Product[] products = new Product[2];

//        public ProductCollection()
//        {
//            products[0] = new Product { id = 1, name = "T-shirt", description = "crop top" };
//            products[1] = new Product { id = 2, name = "Jeans", description = "Stright feat" };
//        }

//        public Product this[string namee]
//        {
//            get
//            {
//                Product response = null;
//                foreach (var proin in products)
//                {
//                    if (proin.name == namee)
//                    {
//                        response = proin; return response;
//                    }
//                }
//                return response;
//            }
//        }
//    }
//}
