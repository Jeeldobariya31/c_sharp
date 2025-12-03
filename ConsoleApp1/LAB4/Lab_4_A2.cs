using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LAB4
{
    internal class Lab_4_A2
    {
        class Employee
        {
            string name;
            int age ;
            double salary ;

            public void setName(string name)
            {
                this.name = name;
            }
            public void setNameAge(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
            public void setAll(string name, int age, double salary)
            {
                this.name = name;
                this.age = age;
                this.salary = salary;
            }
            public void printData()
            {
                Console.WriteLine("Name is :" + this.name);
                Console.WriteLine("Age is :" + this.age);
                Console.WriteLine("Salary is :" + this.salary);
            }
        }
            public static void Run()
        {
            Console.WriteLine("This is Lab-4 , Part-A , Code :2");
            Console.WriteLine("--------------------------------------");

            Employee emp1 = new Employee();
            emp1.setName("Jeel");
            Employee emp2 = new Employee();
            emp2.setNameAge("Smeet", 19);
            Employee emp3 = new Employee();
            emp3.setAll("Dhairya", 20, 10000);

            Console.WriteLine("emp-1 details :" );
              emp1.printData();
            Console.WriteLine("emp-2 details :");
            emp2.printData();
            Console.WriteLine("emp-3 details :");
            emp3.printData();
        }
    }
}
