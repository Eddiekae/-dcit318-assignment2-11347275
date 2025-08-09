using System;

namespace DCIT318_Assignment2_11347275
{
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

    class ProgramTask3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== TASK 3: Interfaces ===");
            IMovable car = new Car();
            IMovable bicycle = new Bicycle();

            car.Move();
            bicycle.Move();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
