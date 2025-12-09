using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LAB5
{
    internal class Lab_5_B5
    {
        interface IPrintable
        {
            void PrintDetails();
        }

        class Book : IPrintable
        {
            private string title;
            private string author;

            public Book(string t, string a)
            {
                title = t;
                author = a;
            }

            public void PrintDetails()
            {
                Console.WriteLine($"Book Title: {title}, Author: {author}");
            }
        }

        class Magazine : IPrintable
        {
            private string name;
            private int issueNumber;

            public Magazine(string n, int issue)
            {
                name = n;
                issueNumber = issue;
            }

            public void PrintDetails()
            {
                Console.WriteLine($"Magazine Name: {name}, Issue Number: {issueNumber}");
            }
        }

        public static void Run()
        {
            Console.WriteLine("This is Lab-5, Part-B, Code: 5");
            Console.WriteLine("--------------------------------------");

            IPrintable printable;

            printable = new Book("The Great Gatsby", "F. Scott Fitzgerald");
            printable.PrintDetails();

            printable = new Magazine("Tech World", 42);
            printable.PrintDetails();
        }
    }
}
