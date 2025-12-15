using System;
using System.Collections.Generic;

namespace ConsoleApp1.LAB6
{
    internal class Lab_6_C10
    {
        public static void Run()
        {
            Console.WriteLine("This is Lab-6 , Part-C , Code : 10");
            Console.WriteLine("--------------------------------------");

            Queue<string> normalPatients = new Queue<string>();
            Queue<string> emergencyPatients = new Queue<string>();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Add Normal Patient");
                Console.WriteLine("2. Add Emergency Patient");
                Console.WriteLine("3. Serve Patient");
                Console.WriteLine("4. View All Patients");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice (1-5): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Normal Patient Name: ");
                        string normal = Console.ReadLine();
                        normalPatients.Enqueue(normal);
                        Console.WriteLine($"{normal} added to Normal queue.");
                        break;

                    case "2":
                        Console.Write("Enter Emergency Patient Name: ");
                        string emergency = Console.ReadLine();
                        emergencyPatients.Enqueue(emergency);
                        Console.WriteLine($"{emergency} added to Emergency queue.");
                        break;

                    case "3":
                        if (emergencyPatients.Count > 0)
                        {
                            string servedEmergency = emergencyPatients.Dequeue();
                            Console.WriteLine($"{servedEmergency} (Emergency) served.");
                        }
                        else if (normalPatients.Count > 0)
                        {
                            string servedNormal = normalPatients.Dequeue();
                            Console.WriteLine($"{servedNormal} (Normal) served.");
                        }
                        else
                        {
                            Console.WriteLine("No patients in queue.");
                        }
                        break;

                    case "4":
                        Console.WriteLine("\nEmergency Patients:");
                        foreach (var p in emergencyPatients)
                            Console.WriteLine("- " + p);

                        Console.WriteLine("\nNormal Patients:");
                        foreach (var p in normalPatients)
                            Console.WriteLine("- " + p);
                        break;

                    case "5":
                        running = false;
                        Console.WriteLine("Exiting... Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
