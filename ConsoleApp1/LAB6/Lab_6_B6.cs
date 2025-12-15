using System;
using System.Collections.Generic;

namespace ConsoleApp1.LAB6
{
    internal class Lab_6_B6
    {
        public static void Run()
        {
            Console.WriteLine("This is Lab-6 , Part-B , Code : 6");
            Console.WriteLine("--------------------------------------");

            List<string> shoppingList = new List<string>();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Add item");
                Console.WriteLine("2. Remove item");
                Console.WriteLine("3. View shopping list");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter item to add: ");
                        string addItem = Console.ReadLine();

                        // avoid  duplicates
                        if (shoppingList.Contains(addItem))
                        {
                            Console.WriteLine($"'{addItem}' already exists in the list!");
                        }
                        else
                        {
                            shoppingList.Add(addItem);
                            Console.WriteLine($"'{addItem}' added to the shopping list.");
                        }
                        break;

                    case "2":
                        Console.Write("Enter item to remove: ");
                        string removeItem = Console.ReadLine();

                        if (shoppingList.Remove(removeItem))
                        {
                            Console.WriteLine($"'{removeItem}' removed from the shopping list.");
                        }
                        else
                        {
                            Console.WriteLine($"'{removeItem}' not found in the list.");
                        }
                        break;

                    case "3":
                        Console.WriteLine("\nShopping List:");
                        if (shoppingList.Count == 0)
                        {
                            Console.WriteLine("List is empty.");
                        }
                        else
                        {
                            foreach (string item in shoppingList)
                            {
                                Console.WriteLine("- " + item);
                            }
                        }
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
