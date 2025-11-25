using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LAB1
{
    internal class Lab_1_B5
    {
        public static void Run()
        {
            Console.WriteLine("This is lab-1 , part-b , code : 5");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Enter Your Basic Salary :");
            int salary = Convert.ToInt32(Console.ReadLine());

            double HRA = salary * 0.1;
            Console.WriteLine("HRA is :"+ HRA);

            double DA = salary * 0.15;
            Console.WriteLine("DA is :" + DA);

            double deduction = salary * 0.08;
            Console.WriteLine("Deduction is :"+deduction);

            Console.WriteLine("Gross Salary :"+salary);

            Console.WriteLine("Net Salary :" + (salary-DA-deduction-HRA));
        }

       
    }
}
