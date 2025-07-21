using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPsC_
{
    //1. abstrct class
    public abstract class Shapes
    {
        public abstract void GetArea();
    }

    //2. interface
    public interface IColorable
    {
        void SetColor(string color);
    }
    //implement interface and abstract class in a class
    public class Rectangle : Shapes, IColorable
    {
        public void SetColor(string color)
        {
            Console.WriteLine($"green is a happniess color so the {color} is to be set in setcolor method");
        }
        public override void GetArea()
        {
            Console.WriteLine("The area of the rectangle is calculated.");
        }
    }

    //create rectangle class object
    public class Class1
    {
        public static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.SetColor("yellow");
            rect.GetArea();
        }
    }
}
