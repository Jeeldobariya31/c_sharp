using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LAB3
{
    internal class Lab_3_B5
    {
        class Person { 
           string name;
           int age;
            bool isDrinkWisky = false;
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
            public Person(string name, int age , bool isDrinkWisky)
            {
                this.name = name;
                this.age = age;
                this.isDrinkWisky=isDrinkWisky;
            }

           public void printData()
            {
                Console.WriteLine("Name is "+ this.name);
                Console.WriteLine("Age  is " + this.age);
                Console.WriteLine("Is Drink Whisky :" + this.isDrinkWisky);
            }


        }
        public static void Run()
        {
            Console.WriteLine("This is Lab-3 , Part-B , Code : 5");
            Console.WriteLine("--------------------------------------");

            Person p1 = new Person("smeet", 18);
            p1.printData();
            Person p2 = new Person("smeet", 18,true);
            p2.printData();

        }
    }
}
