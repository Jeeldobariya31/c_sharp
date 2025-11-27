using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LAB2
{
    internal class Lab_2_A3
    {
        public static void Run()
        {
            Console.WriteLine("This is Lab-2 , Part-A , Code : 3");
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Enter the total marks : ");
            double total = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number Of subject :");
            int sub = Convert.ToInt32(Console.ReadLine());
            
            double percentage = total / sub;
            Console.WriteLine("Output : ");
            Console.WriteLine("Percentage obtained: " + percentage);
            if (percentage >= 75)
            {
                Console.WriteLine("Grade: " + "A");
            }
            else if (percentage >= 60)
            {
                Console.WriteLine("Grade: " + "B");
            }
            else if (percentage >= 45)
            {
                Console.WriteLine("Grade: " + "C");
            }
            else if (percentage >= 35)
            {
                Console.WriteLine("Grade: " + "D");
            }
            else
            {
                Console.WriteLine("FAIL");
            }


        }
    }
}
