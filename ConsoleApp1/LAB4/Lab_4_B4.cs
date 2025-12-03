using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LAB4
{
    internal class Lab_4_B4
    {
        public class Animal
        {
            // Virtual method
            public virtual void Sound()
            {
                Console.WriteLine("Some generic animal sound");
            }
        }
        public class Dog : Animal
        {
            // Override the virtual method
            public override void Sound()
            {
                Console.WriteLine("Dog barks");
            }
        }

        public class Cat : Animal
        {
            // Override the virtual method
            public override void Sound()
            {
                Console.WriteLine("Cat meows");
            }
        }
            public static void Run()
        {
            Console.WriteLine("This is Lab-4 , Part-B , Code :4");
            Console.WriteLine("--------------------------------------");
            // for animal
            Animal animal = new Animal();
            animal.Sound();
            //for dog
            Animal dog = new Dog();
            dog.Sound();
            //for cat 
            Animal cat = new Cat();
            cat.Sound();

        }
    }
}
