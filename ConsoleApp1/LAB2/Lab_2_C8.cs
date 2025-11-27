using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LAB2
{
    internal class Lab_2_C8
    {
        public static void Run()
        {
            Console.WriteLine("This is Lab-2 , Part-C , Code : 8");
            Console.WriteLine("--------------------------------------");

            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int reverse = 0;

            while (num != 0)
            {
                int digit = num % 10;          
                reverse = reverse * 10 + digit; 
                num = num / 10;                
            }

            Console.WriteLine("Reversed Number: " + reverse);

        }
    }
}
