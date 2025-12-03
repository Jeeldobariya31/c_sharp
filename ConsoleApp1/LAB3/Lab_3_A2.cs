using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Text;

namespace ConsoleApp1.LAB3
{
    internal class Lab_3_A2
    {
        class Rectangle
        {
            double length, bredth;
            public Rectangle(double length, double bredth)             {
                this.length = length;
                this.bredth = bredth;
            }

            public double area()
            {
                return this.length * this.bredth;
            }
        }
        public static void Run()
        {
            Console.WriteLine("This is Lab-3 , Part-A , Code : 2");
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Enter length of rectangle");
            double len = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter breadth of rectangle");
            double breadth = Convert.ToDouble(Console.ReadLine());

            Rectangle r1 = new Rectangle(len , breadth);
            double area= r1 .area();
            Console.WriteLine("Area is :"+ area);
            
        }
    }
}
