using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LAB2
{
    internal class Lab_2_B4
    {
        public static void Run()
        {
            Console.WriteLine("This is Lab-2 , Part-B , Code : 4");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Enter Start Point Of Range :");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter End Point Of Range :");
            int end = Convert.ToInt32(Console.ReadLine());

            int odd_sum=0,eve_sum=0;

            for(int i = start; i <= end; i++)

            {
                if(i%2 == 0)
                {
                    eve_sum += i;
                }
                else
                {
                    odd_sum += i;
                }
            }
            Console.WriteLine("Output : ");
            Console.WriteLine("Even Sum : "+eve_sum);
            Console.WriteLine("Odd Sum : " + odd_sum);

        }
    }
}
