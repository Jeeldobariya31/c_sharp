using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LAB4
{
    internal class Lab_4_A1
    {
        public class Calculator
        {
            public int Add(int a, int b)
            {
                return a + b;
            }

            public int Add(int a, int b, int c)
            {
                return a + b + c;
            }

            public double Add(double a, double b)
            {
                return a + b;
            }
        }
        public static void Run()
        {
            Console.WriteLine("This is Lab-4 , Part-A , Code :1");
            Console.WriteLine("--------------------------------------");
            Calculator calc = new Calculator();

            int result1 = calc.Add(5, 10);
            Console.WriteLine($"Sum of two integers: {result1}");

            int result2 = calc.Add(5, 10, 15);
            Console.WriteLine($"Sum of three integers: {result2}");

            double result3 = calc.Add(5.5, 10.2);
            Console.WriteLine($"Sum of two doubles: {result3}");
        }
    }
}

