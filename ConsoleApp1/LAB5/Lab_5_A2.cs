using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LAB5
{
    internal class Lab_5_A2
    {
        class Vehicle
        {
            public void ShowType()
            {
                Console.WriteLine("This is a Vehicle.");
            }
        }

        class Car : Vehicle
        {
            public void ShowType()
            {
                Console.WriteLine("This is a Car.");
            }
        }

        class ElectricCar : Car
        {
            public void ShowType()
            {
                Console.WriteLine("This is an Electric Car.");
            }
        }

        public static void Run()
        {
            Console.WriteLine("This is Lab-5, Part-A, Code: 2");
            Console.WriteLine("--------------------------------------");

            ElectricCar tesla = new ElectricCar();
            tesla.ShowType();
            ((Car)tesla).ShowType();
            ((Vehicle)tesla).ShowType();
        }
    }
}
