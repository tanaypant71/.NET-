using System;

namespace AbstractSealedClasses
{
    public abstract class Shape
    {
        public double h, w;
        public double r;
        public const float PI = 3.14f;
        public abstract double GetArea();
    }

    public class Rectangle : Shape
    {
        public Rectangle(double h, double w)
        {
            this.h = h;
            this.w = w;
        }
        public override double GetArea()
        {
            return w * h;
        }
    }

    public class Circle : Shape
    {
        public Circle(double r)
        {
            this.r = r;
        }
        public override double GetArea()
        {
            return PI * r * r;
        }
    }

    public class Triangle : Shape
    {
        public Triangle(double h, double w)
        {
            this.h = h;
            this.w = w;
        }
        public override double GetArea()
        {
            return (w * h) / 2;
        }
    }

    sealed class Animal
    {

    }

    // Trying to inherit a sealed class (Error)
    // class Dog : Animal
    // {

    // }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius:");
            double radius = double.Parse(Console.ReadLine());
            Circle circle = new Circle(radius);
            Console.WriteLine($"Area of Circle: {circle.GetArea()}");

            Console.WriteLine("***************************");

            Console.WriteLine("Enter length:");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter breadth:");
            double breadth = double.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(length, breadth);
            Console.WriteLine($"Area Rectangle: {rectangle.GetArea()}");

            Console.WriteLine("***************************");

            Console.WriteLine("Enter height:");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter base:");
            double baseh = double.Parse(Console.ReadLine());
            Triangle triangle = new Triangle(height, baseh);
            Console.WriteLine($"Area of Triangle: {triangle.GetArea()}");

            Console.WriteLine("***************************");

            // Uncomment the lines below to test the sealed class
            // Animal animal = new Animal();
            // Dog dog = new Dog();

            Console.ReadKey();
        }
    }
}
