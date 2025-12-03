using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LAB4
{
    internal class Lab_4_A3
    {
        public class Person
        {
            public string Name;
            private int age;
            protected string Address;
            internal string Email;

            public Person(string name, int age, string address, string email)
            {
                Name = name;
                this.age = age;
                Address = address;
                Email = email;
            }

            public void ShowDetails()
            {
                Console.WriteLine($"Name: {Name}, Age: {age}, Address: {Address}, Email: {Email}");
            }
        }
        public class Student : Person
        {
            public Student(string name, int age, string address, string email)
                : base(name, age, address, email) { }

            public void ShowStudentAccess()
            {
                Console.WriteLine($"Accessing public: {Name}");
                //Console.WriteLine($"Accessing private: {age}"); not allow private                                                        
                Console.WriteLine($"Accessing protected: {Address}");
                Console.WriteLine($"Accessing internal: {Email}");
            }
        }
        public class ExternalClass
        {
            public void ShowExternalAccess(Person p)
            {
                Console.WriteLine($"Accessing public: {p.Name}");
                //Console.WriteLine($"Accessing private: {p.age}");  // not allowed (private)
                //Console.WriteLine($"Accessing protected: {p.Address}"); //  not allowed (protected)
                Console.WriteLine($"Accessing internal: {p.Email}");
            }
        }
        public static void Run()
        {
            Console.WriteLine("This is Lab-4 , Part-A , Code :3");
            Console.WriteLine("--------------------------------------");

            Person p1 = new Person("Jeel", 18, "Pasaya", "jeel@gmail.com");
            Console.WriteLine("Print details (in class method ) :");
            p1.ShowDetails();

            Console.WriteLine("Via Derived Class :");
            Student s = new Student("Smeet", 19, "JAmnagar", "raichu@gmail.com");
            Console.WriteLine("Show Student Details :");
            s.ShowStudentAccess();


            Console.WriteLine("External class call :");
            ExternalClass a = new ExternalClass();
            a.ShowExternalAccess(p1);



        }
    }
}

