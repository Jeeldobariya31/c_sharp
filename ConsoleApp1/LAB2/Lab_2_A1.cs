using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LAB2
{
    internal class Lab_2_A1
    {
        public static void Run()
        {
            Console.WriteLine("This is Lab-2 , Part-A , Code : 1");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Enter Number For Print Table :");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Table of " + num + " is :");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " * " + i + " = " + (num * i));
            }
        }
    }
}
