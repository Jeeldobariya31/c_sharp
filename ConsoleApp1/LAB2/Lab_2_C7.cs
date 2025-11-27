using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LAB2
{
    internal class Lab_2_C7
    {
        public static void Run()
        {
            Console.WriteLine("This is Lab-2 , Part-C , Code : 7");
            Console.WriteLine("--------------------------------------");
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            
            string result =
                (num <= 1) ? "Not Prime" :
                (IsPrime(num, 2) ? "Prime Number" : "Not Prime");

            
            Console.WriteLine(result);
        }

        static bool IsPrime(int num, int i)
        {
            return (i * i > num) ? true :
                   (num % i == 0) ? false :
                   IsPrime(num, i + 1);
        }
    }
}
