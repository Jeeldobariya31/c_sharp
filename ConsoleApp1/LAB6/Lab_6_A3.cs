using System;

namespace ConsoleApp1.LAB6
{
    internal class Lab_6_A3
    {
        public static void Run()
        {
            Console.WriteLine("This is Lab-6 , Part-A , Code : 3");
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Enter String :");
            string s = Console.ReadLine();

            int vowels = 0, consonants = 0;

            foreach (char ch in s)
            {
                
                if (char.IsLetter(ch))
                {
                    char lower = char.ToLower(ch);

                    if (lower == 'a' || lower == 'e' || lower == 'i' || lower == 'o' || lower == 'u')
                    {
                        vowels++;
                    }
                    else
                    {
                        consonants++;
                    }
                }
            }

            Console.WriteLine("Total Vowels: " + vowels);
            Console.WriteLine("Total Consonants: " + consonants);
        }
    }
}
