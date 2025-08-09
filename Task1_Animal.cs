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

    // ----------------- MAIN PROGRAM FOR TASK 1 -----------------
    class ProgramTask1
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

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
