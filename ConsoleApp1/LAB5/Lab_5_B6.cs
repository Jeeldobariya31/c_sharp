using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LAB5
{
    internal class Lab_5_B6
    {
        interface IMovable
        {
            void Move();
        }

        interface ISound
        {
            void MakeSound();
        }

        class Robot : IMovable, ISound
        {
            public void Move()
            {
                Console.WriteLine("Robot is moving forward.");
            }

            public void MakeSound()
            {
                Console.WriteLine("Robot is making a beeping sound.");
            }
        }

        public static void Run()
        {
            Console.WriteLine("This is Lab-5, Part-B, Code: 6");
            Console.WriteLine("--------------------------------------");

            IMovable movableRobot = new Robot();
            ISound soundRobot = new Robot();

            movableRobot.Move();
            soundRobot.MakeSound();
        }
    }
}
