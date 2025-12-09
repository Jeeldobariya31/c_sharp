using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LAB5
{
    internal class Lab_5_C7
    {
        abstract class Payment
        {
            public abstract void MakePayment(double amount);
        }

        class CreditCardPayment : Payment
        {
            public override void MakePayment(double amount)
            {
                if (amount < 100)
                {
                    throw new Exception("Payment amount must be at least ₹100.");
                }
                Console.WriteLine($"Credit Card Payment of ₹{amount} processed successfully.");
            }
        }

        class UPIPayment : Payment
        {
            public override void MakePayment(double amount)
            {
                if (amount < 100)
                {
                    throw new Exception("Payment amount must be at least ₹100.");
                }
                Console.WriteLine($"UPI Payment of ₹{amount} processed successfully.");
            }
        }

        public static void Run()
        {
            Console.WriteLine("This is Lab-5, Part-C, Code: 7");
            Console.WriteLine("--------------------------------------");

            try
            {
                Payment payment;

                payment = new CreditCardPayment();
                payment.MakePayment(500);

                payment = new UPIPayment();
                payment.MakePayment(50); // This will throw exception
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
