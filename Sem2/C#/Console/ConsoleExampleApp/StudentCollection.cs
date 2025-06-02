using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExampleApp
{
    internal class StudentCollection
    {
        public Student[] studs = new Student[5];

        public Student this[int index]
        {
            get { return studs[index]; }
            set{ studs[index] = value;}
        }
        

    }
}
