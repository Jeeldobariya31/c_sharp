using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LAB3
{
    internal class Lab_3_C8
    {
        class CarRental
        {
            public string carModel;
            public double dailyRate;
            public int rentedDays;

            public CarRental(string model, double rate, int days)
            {
                carModel = model;
                dailyRate = rate;
                rentedDays = days;
            }

            public double CalculateRent()
            {
                if (rentedDays <= 0)
                    throw new Exception("Rented days must be greater than zero.");

                return dailyRate * rentedDays;
            }
        }



        public static void Run()
        {
            Console.WriteLine("This is Lab-3 , Part-C , Code : 8");
            Console.WriteLine("--------------------------------------");
            try
            {
                CarRental car = new CarRental("Honda City", 60, 3);
                Console.WriteLine("Total Rent: " + car.CalculateRent());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
