using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTupleDelegateOopsConcepts
{
    class student
    {
        public int sid { get; set; }

        public string sname { get; set; }

        public int age { get; set; }

        public override string ToString()
        {
            return $"id :- {sid} sname :- {sname} age :- {age}";
        }
        public string getData()
        {
            return $"id :- {sid} sname :- {sname} age :- {age}";
        }
    }

    class studnetCollection1
    {
        public student[] stud = new student[5];

        public student this[int index]
        {
            get => stud[index];
            set => stud[index] = value;
        }

        public student this[String stud_name]
        {
            get {
                student student = null;

                for (int i = 0; i < 3; i++)
                {
                    if (stud[i].sname.Equals(stud_name))
                    {
                        student = stud[i];
                        break;
                    }
                }
                return student;
            }
        }
    }
    class StudnetObjIndexer
    {
        static void Main(string[] args)
        {
            studnetCollection1 studnetCollection = new studnetCollection1();

            studnetCollection[0] = new student() { sid = 1, sname = "dhruvi", age = 21 };
            studnetCollection[1] = new student() { sid = 2, sname = "kkkkkk", age = 25 };
            studnetCollection[2] = new student() { sid = 3, sname = "riya", age = 30 };


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(studnetCollection[i].ToString());
            }

            Console.WriteLine("Enter sudent name :- ");
            string name = Console.ReadLine();

            Console.WriteLine(studnetCollection[name].getData());
        }
    }
}
