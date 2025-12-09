using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LAB5
{
    internal class Lab_5_A1
    {
        // Base class
        class Animal
        {
            public void Eat()
            {
                Console.WriteLine("Animal is eating.");
            }
        }

        // Derived class
        class Dog : Animal
        {
            public void Bark()
            {
                Console.WriteLine("Dog is barking.");
            }
        }

        public static void Run()
        {
            Console.WriteLine("This is Lab-5, Part-A, Code: 1");
            Console.WriteLine("--------------------------------------");

            
            Animal genericAnimal = new Animal();
            genericAnimal.Eat();

            Dog dog = new Dog();
            dog.Eat();   
            dog.Bark();  
        }
    }
}
