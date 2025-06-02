using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPsC_
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Car mycar = new Car();
            mycar.Color = "Red";
            //Console.WriteLine(mycar.Color);

            //mycar.Run(500);

            //---------Overriding-----------

            Shape shape = new Shape();
            Shape circle = new Circle();
            Shape rectangel = new Rectangel();


            //shape.Draw();
            //circle.Draw();
            //rectangel.Draw();

            //--------------------

            //  Animal animal = new Animal();
            Animal dog = new Dog();
            //Dog dog = new Dog();


            dog.Sound();

            //------------------interface-------------------------------

            FlyingCar flyingCar = new FlyingCar();

            flyingCar.Drive();
            flyingCar.Speak();
            flyingCar.Fly();

        }
    }
    //==============   End Main method   ====================

    public class Vehical
    {
        private int speed = 100;
        public void Run()
        {
            Console.WriteLine("The vehical run method :- " + speed);
        }
        public void Run(int myspeed)
        {
            Console.WriteLine("The vehical run int method :- " + myspeed);
        }
    }

    public class Car : Vehical
    {

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        string color = "bule";

    }

    //sealed
    public class Electric : Car
    {

    }

    //--------------orverriding(Inheritance)---------------------

    public class Shape
    {
        // statically-bound new keyword
        public string HomeAddress()

        {
            return "Hoem address in shape class";
        }
        // dynamically-bound override keyword
        public virtual void Draw()
        {
            Console.WriteLine("Shape class");
        }
    }

    public class Circle : Shape
    {
        public new string HomeAddress()
        {
            return "home address in circle class";
        }
        public override void Draw()
        {
            Console.WriteLine("Circle class : circle ");
        }
    }
    public class Rectangel : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Rectangel class : Rectangel ");
        }


    }

    //-------------------------------------------------

    //--------------abstract-------------------

    abstract public class Animal
    {
        public abstract void Sound();

    }

    public class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("dog class : dog ");
        }
    }


    //-------------------------------------------------
}
