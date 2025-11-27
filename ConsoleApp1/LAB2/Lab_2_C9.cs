using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LAB2
{
    internal class Lab_2_C9
    {
        public static void Run()
        {
            Console.WriteLine("This is Lab-2 , Part-C , Code : 9");
            Console.WriteLine("--------------------------------------");
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            int original = num;
            int reverse = 0;

            while (num != 0)
            {
                int digit = num % 10;
                reverse = reverse * 10 + digit;
                num = num / 10;
            }

            if (original == reverse)
            {
                Console.WriteLine("The number is a Palindrome.");
            }
            else
            {
                Console.WriteLine("The number is NOT a Palindrome.");
            }
        }
    }
}
