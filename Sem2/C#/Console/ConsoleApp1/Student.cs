using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        public int id;
        public string name;
        public int age;

        public Student()
        {
            id = 1;
            name = "ABC";
        }
        public void GetData()
        {
            Console.WriteLine("ID: " + id.ToString() + " Name : " + name + " and Age: " + age.ToString());
        }

        public override string ToString()
        {
            return "ID: " + id.ToString() + " Name : " + name + " and Age: " + age.ToString();
        }
    }
}
