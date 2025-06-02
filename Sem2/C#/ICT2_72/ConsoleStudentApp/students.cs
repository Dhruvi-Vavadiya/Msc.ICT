using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStudentApp
{
    internal class students
    {
        public int id;
        public string name; 
        public int age;

        public students()
        {
            id = 0;
            name = "";
            age = 0;
        }

        public void getData()
        {
            Console.WriteLine(" id:- " + id + " Name:- " + name + " Age :-" + age);
        }
    }
}
