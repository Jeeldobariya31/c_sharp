using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LAB2
{
    internal class Lab_2_C10
    {
        public static void Run()
        {
            Console.WriteLine("This is Lab-2 , Part-C , Code : 10");
            Console.WriteLine("--------------------------------------");

            Console.Write("Enter Number of Terms: ");
            int step = Convert.ToInt32(Console.ReadLine());

            long t1 = 0, t2 = 1;

            Console.Write("Fibonacci Series (" + step + " terms):");

            if (step >= 1)
                Console.Write(t1 + " ");

            if (step >= 2)
                Console.Write(t2 + " ");

            int count = 3;
            while (count <= step)
            {
                long t3 = t1 + t2;
                Console.Write(t3 + " ");
                t1 = t2;
                t2 = t3;
                count++;
            }

            Console.WriteLine();
        }
    }
}
