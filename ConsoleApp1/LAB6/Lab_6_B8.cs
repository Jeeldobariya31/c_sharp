using System;
using System.Collections.Generic;

namespace ConsoleApp1.LAB6
{
    internal class Lab_6_B8
    {
        public static void Run()
        {
            Console.WriteLine("This is Lab-6 , Part-B , Code : 8");
            Console.WriteLine("--------------------------------------");

            HashSet<string> emailSet = new HashSet<string>();

            bool running = true;
            while (running)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Add email");
                Console.WriteLine("2. View all emails");
                Console.WriteLine("3. Show total unique emails");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter email address: ");
                        string email = Console.ReadLine();

                        if (emailSet.Add(email))
                        {
                            Console.WriteLine($"'{email}' added successfully.");
                        }
                        else
                        {
                            Console.WriteLine($"'{email}' already exists in the list!");
                        }
                        break;

                    case "2":
                        Console.WriteLine("\nUnique Email Addresses:");
                        if (emailSet.Count == 0)
                        {
                            Console.WriteLine("No emails stored yet.");
                        }
                        else
                        {
                            foreach (string e in emailSet)
                            {
                                Console.WriteLine("- " + e);
                            }
                        }
                        break;

                    case "3":
                        Console.WriteLine($"\nTotal unique emails stored: {emailSet.Count}");
                        break;

                    case "4":
                        running = false;
                        Console.WriteLine("Exiting... Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter 1-4.");
                        break;
                }
            }
        }
    }
}
