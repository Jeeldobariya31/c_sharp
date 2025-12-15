using System;
using System.Collections.Generic;

namespace ConsoleApp1.LAB6
{
    internal class Lab_6_B7
    {
        public static void Run()
        {
            Console.WriteLine("This is Lab-6 , Part-B , Code : 7");
            Console.WriteLine("--------------------------------------");

            
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            
            sentence = sentence.ToLower();

            string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

           
            Console.WriteLine("\nWord Frequency:");
            foreach (var kvp in wordCount)
            {
                Console.WriteLine($"{kvp.Key} : {kvp.Value}");
            }
        }
    }
}
