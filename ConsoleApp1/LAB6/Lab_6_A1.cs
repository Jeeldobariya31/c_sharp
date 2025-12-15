using System;
using System.Collections.Generic;

namespace ConsoleApp1.LAB6
{
    internal class Lab_6_A1
    {
        public static void Run()
        {
            Console.WriteLine("This is Lab-6 , Part-A , Code : 1");
            Console.WriteLine("--------------------------------------");

            Stack<String> s1 = new Stack<String>();
            int ch;
            int i = 1;
            do
            {
                Console.WriteLine("Enter 0 For Exit");
                Console.WriteLine("Enter 1 For Add Ele");
                Console.WriteLine("Enter 2 For Undo Ele");
                Console.WriteLine("Enter Choice :");
                ch = Convert.ToInt32(Console.ReadLine());
                if (ch == 1)
                {
                    s1.Push("Task " + i);
                    Console.WriteLine("Task " + i + " Added");
                    i++;

                }
                else if (ch == 2)
                {
                    if (s1.Count == 0)
                    {
                        Console.WriteLine("Stack is Empty");
                    }
                    else
                    {
                        Console.WriteLine( s1.Pop() + " Removed");
                    }
                }
                 else if (ch == 0)
                {
                    Console.WriteLine("Exit");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            } while (ch != 0);

        }
    }
}