using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LAB4
{
    internal class Lab_4_C7
    {
        class LibraryItem
        {
            private string Title;
            private string Author;

            public LibraryItem(string title, string author)
            {
                Title = title;
                Author = author;
            }

            public string GetTitle() => Title;
            public string GetAuthor() => Author;

            public virtual void DisplayInfo()
            {
                Console.WriteLine($"Title: {Title}, Author: {Author}");
            }
        }
        class Book : LibraryItem
        {
            private string Genre;

            public Book(string title, string author, string genre)
                : base(title, author)
            {
                Genre = genre;
            }

            public override void DisplayInfo()
            {
                Console.WriteLine($"Book - Title: {GetTitle()}, Author: {GetAuthor()}, Genre: {Genre}");
            }
        }

        class Magazine : LibraryItem
        {
            private int IssueNumber;

            public Magazine(string title, string author, int issueNumber)
                : base(title, author)
            {
                IssueNumber = issueNumber;
            }

            public override void DisplayInfo()
            {
                Console.WriteLine($"Magazine - Title: {GetTitle()}, Author: {GetAuthor()}, Issue: {IssueNumber}");
            }
        }
        public static void Run()
        {
            Console.WriteLine("This is Lab-4 , Part-C , Code :7");
            Console.WriteLine("--------------------------------------");

            LibraryItem book = new Book("C# Basics", "Dr.Jeel Dobariya", "Programming");
            LibraryItem magazine = new Magazine("Tech Monthly", "Prof.Jeelu", 33);

            book.DisplayInfo();
            magazine.DisplayInfo();
        }
    }
}
