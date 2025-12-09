using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LAB5
{
    internal class Lab_5_C8
    {
        abstract class Employee
        {
            public string Name { get; set; }
            public double Salary { get; set; }

            public Employee(string name, double salary)
            {
                Name = name;
                Salary = salary;
            }

            public abstract double CalculateBonus();
        }

        class Manager : Employee
        {
            public Manager(string name, double salary) : base(name, salary) { }

            public override double CalculateBonus()
            {
                return Salary * 0.20; // 20% bonus
            }
        }

        class Developer : Employee
        {
            public Developer(string name, double salary) : base(name, salary) { }

            public override double CalculateBonus()
            {
                return Salary * 0.10; // 10% bonus
            }
        }

        public static void Run()
        {
            Console.WriteLine("This is Lab-5, Part-C, Code: 8");
            Console.WriteLine("--------------------------------------");

            Employee emp;

            emp = new Manager("Jeel", 50000);
            Console.WriteLine($"{emp.Name} (Manager) Bonus: ₹{emp.CalculateBonus()}");

            emp = new Developer("Smeet", 40000);
            Console.WriteLine($"{emp.Name} (Developer) Bonus: ₹{emp.CalculateBonus()}");
        }
    }
}
