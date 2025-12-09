using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LAB5
{
    internal class Lab_5_C9
    {
        interface IRentable
        {
            double CalculateRent(int days);
            void DisplayDetails();
        }

        class Car : IRentable
        {
            private string model;
            private double rentPerDay;

            public Car(string model, double rentPerDay)
            {
                this.model = model;
                this.rentPerDay = rentPerDay;
            }

            public double CalculateRent(int days)
            {
                return rentPerDay * days;
            }

            public void DisplayDetails()
            {
                Console.WriteLine($"Car Model: {model}, Rent per Day: ₹{rentPerDay}");
            }
        }

        class Bike : IRentable
        {
            private string model;
            private double rentPerDay;

            public Bike(string model, double rentPerDay)
            {
                this.model = model;
                this.rentPerDay = rentPerDay;
            }

            public double CalculateRent(int days)
            {
                return rentPerDay * days;
            }

            public void DisplayDetails()
            {
                Console.WriteLine($"Bike Model: {model}, Rent per Day: ₹{rentPerDay}");
            }
        }

        public static void Run()
        {
            Console.WriteLine("This is Lab-5, Part-C, Code: 9");
            Console.WriteLine("--------------------------------------");

            int days = 3;

            Car car = new Car("Honda City", 1200);
            car.DisplayDetails();
            Console.WriteLine($"Total Rent for {days} days: ₹{car.CalculateRent(days)}");
            Console.WriteLine();

            Bike bike = new Bike("Royal Enfield", 500);
            bike.DisplayDetails();
            Console.WriteLine($"Total Rent for {days} days: ₹{bike.CalculateRent(days)}");
        }
    }
}
