using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ConsoleApp1.LAB3
{
    internal class Lab_3_B4
    {
        class BankAccount
        {
            int accountNumber;
            string holderName;
            double balance;

            public BankAccount(int accountNumber, string holderName,
            double balance)
            {
                this.accountNumber = accountNumber;
                this.holderName = holderName;
                this.balance = balance;
            }
            public double getBalance()
            {
                return this.balance;
            }
            public void deposit(double amount)
            {
                this.balance += amount;
            }
            public void  withdraw(double amount)
            {
                try 
                {
                    if (this.balance < 500 || this.balance  < amount || (this.balance-amount) < 500)
                    { 
                    throw new Exception("Insuficient Balance");
                    }
                    else
                    {
                        this.balance -= amount;
                        Console.WriteLine("Withdraw Successfully ");
                        Console.WriteLine("Current Balance is :" + this.balance);
                    }
                     
                }
                catch (Exception e) {
                    
                    Console.WriteLine(e.Message);

                }
                
            }

        }
        public static void Run()
        {
            Console.WriteLine("This is Lab-3 , Part-B , Code : 4");
            Console.WriteLine("--------------------------------------");

            BankAccount b1 = new BankAccount(123, "jeel", 5000);
            double a = b1.getBalance();
            Console.WriteLine("Current Balance is :" + a);
            Console.WriteLine("Deposit 5000 -----");
            b1.deposit(5000);
            double b = b1.getBalance();
            Console.WriteLine("After deposit  Balance is :" + b);
            Console.WriteLine("Withdraw 1000 -----");
            b1.withdraw(1000);
           

        }
    }
}