using System;
using System.Collections.Generic;

namespace ConsoleApp1.LAB6
{
    internal class Lab_6_C9
    {
        public static void Run()
        {
            Console.WriteLine("This is Lab-6 , Part-C , Code : 9");
            Console.WriteLine("--------------------------------------");

            Dictionary<string, Queue<string>> libraryRecords = new Dictionary<string, Queue<string>>();

            bool running = true;
            while (running)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Add borrower");
                Console.WriteLine("2. View borrowers of a book");
                Console.WriteLine("3. View all records");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter book title: ");
                        string bookTitle = Console.ReadLine();

                        Console.Write("Enter borrower name: ");
                        string borrower = Console.ReadLine();

                        if (!libraryRecords.ContainsKey(bookTitle))
                        {
                            libraryRecords[bookTitle] = new Queue<string>();
                        }

                        libraryRecords[bookTitle].Enqueue(borrower);
                        Console.WriteLine($"'{borrower}' added to book '{bookTitle}'.");
                        break;

                    case "2":
                        Console.Write("Enter book title to view borrowers: ");
                        string viewBook = Console.ReadLine();

                        if (libraryRecords.ContainsKey(viewBook))
                        {
                            Console.WriteLine($"\nBorrowers of '{viewBook}':");
                            foreach (string b in libraryRecords[viewBook])
                            {
                                Console.WriteLine("- " + b);
                            }
                        }
                        else
                        {
                            Console.WriteLine($"No records found for '{viewBook}'.");
                        }
                        break;

                    case "3":
                        Console.WriteLine("\nAll Library Records:");
                        if (libraryRecords.Count == 0)
                        {
                            Console.WriteLine("No records available.");
                        }
                        else
                        {
                            foreach (var record in libraryRecords)
                            {
                                Console.WriteLine($"\nBook: {record.Key}");
                                Console.WriteLine("Borrowers:");
                                foreach (string b in record.Value)
                                {
                                    Console.WriteLine("- " + b);
                                }
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