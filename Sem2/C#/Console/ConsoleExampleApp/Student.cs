using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExampleApp
{
    internal class Student
    {
        public int id;
        public string name;
        public int age;

        public Student() { 
            id = 0;
            name = "";
            age= 0;
        }

        public void getData()
        {
            Console.WriteLine("id :- " + id + " name :- " + name + " age :- " + age);
        }

        public Student getRecord(String sName)
        {
            Student response = null;
            foreach (Student student in Student)
            {
                if (student.name.Equals(sName)
                {
                    return response;
                    break;
                }
            }
            return response;


        }
        public override string ToString()
        {
            return "ID: " + id.ToString() + " Name : " + name + " and Age: " + age.ToString();
        }
    }
}
