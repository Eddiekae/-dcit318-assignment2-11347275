using System;

namespace DCIT318_Assignment2_11347275
{
    // ----------------- TASK 1: INHERITANCE & METHOD OVERRIDING -----------------
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    // ----------------- TASK 2: ABSTRACT CLASSES & METHODS -----------------
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

    // ----------------- TASK 3: INTERFACES -----------------
    interface IMovable
    {
        void Move();
    }

    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    // ----------------- MAIN PROGRAM -----------------
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== TASK 1: Inheritance & Method Overriding ===");
            Animal genericAnimal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            genericAnimal.MakeSound();
            dog.MakeSound();
            cat.MakeSound();

            Console.WriteLine("\n=== TASK 2: Abstract Classes & Methods ===");
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);

            Console.WriteLine($"Circle Area: {circle.GetArea()}");
            Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");

            Console.WriteLine("\n=== TASK 3: Interfaces ===");
            IMovable car = new Car();
            IMovable bicycle = new Bicycle();

            car.Move();
            bicycle.Move();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
