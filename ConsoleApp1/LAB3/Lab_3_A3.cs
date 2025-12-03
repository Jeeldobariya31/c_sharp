using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LAB3
{
    internal class Lab_3_A3
    {
        public static void Run()
        {
            Console.WriteLine("This is Lab-3 , Part-A , Code : 3");
            Console.WriteLine("--------------------------------------");
            try
            {
                Console.WriteLine("Enter Number-1 :");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Number-2 :");
                int num2 = Convert.ToInt32(Console.ReadLine());

                double div = num1 / num2;      
                Console.WriteLine("Division is :"+ div);
            }
            catch (Exception e) { 
                Console.WriteLine(e.Message);
            }
        }
    }
}
