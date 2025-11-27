using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LAB2
{
    internal class Lab_2_A2
    {
        public static void Run()
        {
            Console.WriteLine("This is Lab-2 , Part-A , Code : 2");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Enter String :");
            string str = Console.ReadLine();
            int sc_count=0,al_count=0,dg_count = 0 ,space = 0;
           

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    dg_count++;
                }
                else if (char.IsWhiteSpace(str[i]))
                {
                    space++;
                }
                else if (char.IsLetter(str[i]))
                {
                    al_count++;
                }
                else
                {
                    sc_count++;
                }
            }
            Console.WriteLine("=> Output :");
            Console.WriteLine("Special Charecter :" + sc_count);
            Console.WriteLine("Alphabate  :" + al_count);
            Console.WriteLine("Digit :" + dg_count);

        }
    }
}
