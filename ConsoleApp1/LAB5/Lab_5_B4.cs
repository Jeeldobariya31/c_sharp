using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LAB5
{
    internal class Lab_5_B4
    {
        abstract class Appliance
        {
            public abstract void TurnOn();
        }

        class Fan : Appliance
        {
            public override void TurnOn()
            {
                Console.WriteLine("Fan is now running.");
            }
        }

        class Light : Appliance
        {
            public override void TurnOn()
            {
                Console.WriteLine("Light is now switched on.");
            }
        }

        public static void Run()
        {
            Console.WriteLine("This is Lab-5, Part-B, Code: 4");
            Console.WriteLine("--------------------------------------");

            Appliance appliance;

            appliance = new Fan();
            appliance.TurnOn();

            appliance = new Light();
            appliance.TurnOn();
        }
    }
}
