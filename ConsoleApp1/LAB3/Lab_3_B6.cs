using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LAB3
{
    internal class Lab_3_B6
    {
        class Employee
        {
            public int empId;
            public string empName;
            public double salary;

            public Employee(int empId, string empName, int salary)
            {
                this.empId = empId;
                this.empName = empName;
                this.salary = salary;
            }

            public void ShowData()
            {
                Console.WriteLine(empName + " " + empId + " " + salary);
            }
        }
        public static void Run()
        {
            Console.WriteLine("This is Lab-3 , Part-B , Code : 6");
            Console.WriteLine("--------------------------------------");
            Employee[] employees = new Employee[3];
            employees[0] = new Employee(1, "Smit", 1000);
            employees[1] = new Employee(2, "XYZ", 200);
            employees[2] = new Employee(3, "ABC", 300);

            foreach (Employee employee in employees)
            {
                employee.ShowData();
            }
        }
    }
}
