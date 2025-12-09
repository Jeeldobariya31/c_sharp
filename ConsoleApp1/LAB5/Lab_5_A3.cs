using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LAB5
{
    internal class Lab_5_A3
    {
        // Base class
        class Shape
        {
            public virtual double Area()
            {
                return 0;
            }
        }

        // Derived class Circle
        class Circle : Shape
        {
            private double radius;

            public Circle(double r)
            {
                radius = r;
            }

            public override double Area()
            {
                return Math.PI * radius * radius;
            }
        }

        // Derived class Rectangle
        class Rectangle : Shape
        {
            private double length;
            private double width;

            public Rectangle(double l, double w)
            {
                length = l;
                width = w;
            }

            public override double Area()
            {
                return length * width;
            }
        }

        public static void Run()
        {
            Console.WriteLine("This is Lab-5, Part-A, Code: 3");
            Console.WriteLine("--------------------------------------");

            // Polymorphism demonstration
            Shape shape;

            shape = new Circle(5);
            Console.WriteLine("Area of Circle: " + shape.Area());

            shape = new Rectangle(4, 6);
            Console.WriteLine("Area of Rectangle: " + shape.Area());
        }
    }
}
