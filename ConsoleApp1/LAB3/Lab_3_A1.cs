using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LAB3
{
    internal class Lab_3_A1
    {
        public class Student
        {
            public string Name;
            public int RollNo;
            public int Marks;

            public void setData(String name ,int RollNo , int Marks )
            {
                this.Name = name;
                this.RollNo = RollNo;
                this.Marks = Marks;
            }
            public void getData() 
            { 
                Console.WriteLine("Name : " + this.Name);
                Console.WriteLine("RollNo :"+this.RollNo);
                Console.WriteLine("Marks :" + this.Marks);
            }
        }
         public static void Run()
        {
            Console.WriteLine("This is Lab-3 , Part-A , Code : 1");
            Console.WriteLine("--------------------------------------");

            Student student1 = new Student();
            //student1.Name = "Jeel";
            //student1.Marks = 100;
            //student1.RollNo = 1;
            student1.setData("Jeel", 1, 100);

            Student student2 = new Student();
            student2.setData("Smeet", 2, 100);


            Console.WriteLine("Student - 1 Data :");
            student1.getData();
            Console.WriteLine("Student - 2 Data :");
            student2.getData();

        }
    }
}
