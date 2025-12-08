using System;

namespace ConsoleApp1.LAB4
{
    internal class Lab_4_C6
    {
        class BankAccount
        {
            private int accountNumber;
            private string holderName;
            private double balance;

            public BankAccount(int accNo, string name, double initialBalance)
            {
                accountNumber = accNo;
                holderName = name;
                balance = initialBalance;
            }

            public int GetAccountNumber() => accountNumber;
            public string GetHolderName() => holderName;
            public double GetBalance() => balance;

            public void Deposit(double amount)
            {
                balance += amount;
            }

            public void Withdraw(double amount)
            {
                if (amount <= balance)
                    balance -= amount;
                else
                    Console.WriteLine("Insufficient balance");
            }
        }

        class BankTransaction
        {
            public void Transfer(BankAccount from, BankAccount to, double amount)
            {
                if (amount <= from.GetBalance())
                {
                    from.Withdraw(amount);
                    to.Deposit(amount);
                    Console.WriteLine($"Transferred {amount} from {from.GetHolderName()} to {to.GetHolderName()}");
                }
                else
                {
                    Console.WriteLine("Transfer failed: Insufficient funds");
                }
            }

            public void Transfer(BankAccount from, BankAccount to, double amount, string description)
            {
                if (amount <= from.GetBalance())
                {
                    from.Withdraw(amount);
                    to.Deposit(amount);
                    Console.WriteLine($"Transferred {amount} from {from.GetHolderName()} to {to.GetHolderName()} for {description}");
                }
                else
                {
                    Console.WriteLine("Transfer failed: Insufficient funds");
                }
            }
        }

        public static void Run()
        {
            Console.WriteLine("This is Lab-4 , Part-C , Code :6");
            Console.WriteLine("--------------------------------------");

            BankAccount acc1 = new BankAccount(101, "Jeel", 5000);
            BankAccount acc2 = new BankAccount(102, "Smeet", 3000);

            BankTransaction transaction = new BankTransaction();

            transaction.Transfer(acc1, acc2, 1000);
            transaction.Transfer(acc1, acc2, 500, "Rent Payment");

            Console.WriteLine($"{acc1.GetHolderName()} Balance: {acc1.GetBalance()}");
            Console.WriteLine($"{acc2.GetHolderName()} Balance: {acc2.GetBalance()}");
        }
    }
}
