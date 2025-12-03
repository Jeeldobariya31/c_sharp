using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LAB4
{
    internal class Lab_4_B5
    {
        public class Shape
        {
            // Virtual method in base class
            public virtual double CalculateArea()
            {
                return 0; // Default implementation
            }
        }

        public class Circle : Shape
        {
            private double radius;

            public Circle(double r)
            {
                radius = r;
            }

            public override double CalculateArea()
            {
                return Math.PI * radius * radius; // πr²
            }
        }

        public class Rectangle : Shape
        {
            private double length, width;

            public Rectangle(double l, double w)
            {
                length = l;
                width = w;
            }

            public override double CalculateArea()
            {
                return length * width; 
            }
        }

        public class Triangle : Shape
        {
            private double baseLength, height;

            public Triangle(double b, double h)
            {
                baseLength = b;
                height = h;
            }

            public override double CalculateArea()
            {
                return 0.5 * baseLength * height; 
            }
        }
        public static void Run()
        {
            Console.WriteLine("This is Lab-4 , Part-B , Code :5");
            Console.WriteLine("--------------------------------------");
            Shape s;

            s = new Circle(5);
            Console.WriteLine("Circle Area: " + s.CalculateArea());

            s = new Rectangle(4, 6);
            Console.WriteLine("Rectangle Area: " + s.CalculateArea());

            s = new Triangle(3, 7);
            Console.WriteLine("Triangle Area: " + s.CalculateArea());
        }
    }
}
