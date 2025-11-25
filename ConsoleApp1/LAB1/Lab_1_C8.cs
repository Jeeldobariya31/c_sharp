using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LAB1
{
    internal class Lab_1_C8
    {
        public static void Run()
        {
            Console.WriteLine("This is a Lab-1 , Part-C , code:8 ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Enter the amount in Indian Rupees: ");
            double ind = Convert.ToInt32(Console.ReadLine());

            double usd = ind * 89.21;
            Console.WriteLine("IND: " + ind + " USD: " + usd);
            double eur = ind * 103.01;
            Console.WriteLine("IND: " + ind + " EUR: " + eur);
            double gbp = ind * 117.19;
            Console.WriteLine("IND: " + ind + " GBP: " + gbp);
        }
    }
}
