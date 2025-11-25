using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LAB1
{
    internal class Lab_1_C9
    {
        public static void Run()
        {
            Console.WriteLine("This is a Lab-1 , Part-C , code:9 ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Enter the total purchase amount: ");
            double total_amt = Convert.ToDouble(Console.ReadLine());
            double discount;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Original Amount: " + total_amt);


            if (total_amt >= 10000)
            {
                discount = total_amt * 0.15;
                Console.WriteLine("Discounted amount is: " + discount);
                Console.WriteLine("Final Payable amount is: " + (total_amt - discount));
            }
            else if (total_amt >= 5000)
            {
                discount = total_amt * 0.1;
                Console.WriteLine("Discounted amount is: " + discount);
                Console.WriteLine("Final Payable amount is: " + (total_amt - discount));
            }
            else
            {
                discount = total_amt * 0.05;
                Console.WriteLine("Discounted amount is: " + discount);
                Console.WriteLine("Final Payable amount is: " + (total_amt - discount));
            }
        }
    }
}
