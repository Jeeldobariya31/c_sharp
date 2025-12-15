using System;


namespace ConsoleApp1.LAB6
{
    internal class Lab_6_A2
    {
        public static void Run()
        {
            Console.WriteLine("This is Lab-6 , Part-A , Code : 2");
            Console.WriteLine("-------------------------------- ------");

            Queue<String> queue = new Queue<String>();

            int ch;
            int i = 1;

            do
            {
                Console.WriteLine("---------------");
                Console.WriteLine("Enter 0 For Exit");
                Console.WriteLine("Enter 1 For Add Customer");
                Console.WriteLine("Enter 2 For Served Customer");
                Console.WriteLine("Enter Choice :");
                ch = Convert.ToInt32(Console.ReadLine());

                if(ch == 0)
                {
                    Console.WriteLine("Exiting........");
                    break;
                }
                else
                {
                    if (ch == 1)
                    {
                        queue.Enqueue("Customer - " + i);
                        Console.WriteLine("Customer - " + i + " Added");
                        i++;
                    }
                    else
                    {
                       if(queue.Count != 0)
                        {
                            Console.WriteLine(queue.Dequeue() + " Served");
                        }
                        else
                        {
                            Console.WriteLine("All Served");
                        }
                        if ((queue.Count - 1) > 0)
                        {
                            Console.WriteLine("Next One Is :" + queue.Peek());
                        }
                        else
                        {
                            Console.WriteLine("Next NO Remain ");
                        }
                    }
                    
                }
            }
            while (true);

        }

    }
}