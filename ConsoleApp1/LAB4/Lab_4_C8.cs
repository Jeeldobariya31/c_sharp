using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LAB4
{
    class Customer
    {
        private string Name;
        private double BillAmount;

        public Customer(string name, double amount)
        {
            Name = name;
            BillAmount = amount;
        }

        public string GetName() => Name;
        public double GetBillAmount() => BillAmount;

        public virtual double CalculateBill()
        {
            return BillAmount;
        }
    }

    class RegularCustomer : Customer
    {
        public RegularCustomer(string name, double amount) : base(name, amount) { }

        public override double CalculateBill()
        {
            return GetBillAmount() * 0.95; // 5% discount
        }
    }

    class PremiumCustomer : Customer
    {
        public PremiumCustomer(string name, double amount) : base(name, amount) { }

        public override double CalculateBill()
        {
            return GetBillAmount() * 0.85; // 15% discount
        }
    }

    internal class Lab_4_C8
    {
        public static void Run()
        {
            Console.WriteLine("This is Lab-4 , Part-C , Code :8");
            Console.WriteLine("--------------------------------------");
            Customer regular = new RegularCustomer("Jeel Dobariya", 1000);
            Customer premium = new PremiumCustomer("Unknown ben Jeel bhai Dobariya", 1000);

            Console.WriteLine($"Regular Coustomer {regular.GetName()} has Final Bill: {regular.CalculateBill()}");
            Console.WriteLine($"Premium Coustomer {premium.GetName()} has Final Bill: {premium.CalculateBill()}");
        }
    }
}
