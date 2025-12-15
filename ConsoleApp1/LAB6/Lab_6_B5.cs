using System;

namespace ConsoleApp1.LAB6
{
    internal class Lab_6_B5
    {
        public static void Run()
        {
            Console.WriteLine("This is Lab-6 , Part-B , Code : 5");
            Console.WriteLine("--------------------------------------");

            
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            
            sentence = sentence.ToLower();

           
            string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            
            string[] uniqueWords = new string[words.Length];
            int[] counts = new int[words.Length];
            int uniqueCount = 0;

            // Loop through words and count manually
            foreach (string word in words)
            {
                bool found = false;
                for (int i = 0; i < uniqueCount; i++)
                {
                    if (uniqueWords[i] == word)
                    {
                        counts[i]++;
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    uniqueWords[uniqueCount] = word;
                    counts[uniqueCount] = 1;
                    uniqueCount++;
                }
            }

            
            Console.WriteLine("\nWord Frequency:");
            for (int i = 0; i < uniqueCount; i++)
            {
                Console.WriteLine($"{uniqueWords[i]} : {counts[i]}");
            }
        }
    }
}
