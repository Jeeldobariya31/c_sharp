using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LAB2
{
    internal class Lab_2_C6
    {
        public static void Run()
        {  
            Console.WriteLine("This is Lab-2 , Part-C , Code : 6");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Enter Password:");
            string pass = Console.ReadLine();
            bool islen = false;
            bool isdig = false;
            bool issc = false;
            bool islc = false;
            bool isuc = false;
            bool isws= false;
            if (pass.Length >= 8)
            {
                islen = true;
            }


            foreach (char i in pass)
            {
                if (Char.IsDigit(i))
                {
                    isdig=true;
                }
                else if (Char.IsUpper(i))
                {
                    isuc=true;
                }
                else if (Char.IsLower(i))
                {
                    islc = true;
                }
                
                else if (Char.IsWhiteSpace(i))
                {
                    isws=true;
                }
                else 
                {
                    issc = true;
                }

            }

            if (isws)
            {
                Console.WriteLine("Your Password Is Not Strong Because it have space");
            }
            else
            {
                if (islen && isuc && islc && issc && isdig)
                {
                    Console.WriteLine("Your Password Is Strong");
                }
                else
                {
                    Console.WriteLine("Your Password Is not Strong");
                }
            }
        }
    }
}
