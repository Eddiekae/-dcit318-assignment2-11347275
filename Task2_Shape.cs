using System;

namespace DCIT318_Assignment2_11347275
{
    abstract class Shape
    {
        public abstract double GetArea();
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class ProgramTask2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== TASK 2: Abstract Classes & Methods ===");
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);

            Console.WriteLine($"Circle Area: {circle.GetArea()}");
            Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
