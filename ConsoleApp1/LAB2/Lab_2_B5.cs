using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LAB2
{
    internal class Lab_2_B5
    {
        public static void Run()
        {
            Console.WriteLine("This is Lab-2 , Part-B , Code : 5");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Enter Number :");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = 1;
          for(int i = 1; i <= num;i++)
            {
                temp *= i;
            }

            Console.WriteLine("Output :");
            Console.WriteLine("Factorial of " + num + " Is =" + temp);
        }
    }
}
