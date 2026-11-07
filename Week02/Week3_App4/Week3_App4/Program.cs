using System;

namespace Week3App4
{
    class BankAccount
    {
        private string owner;
        private double balance;

        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public double Balance
        {
            get { return balance; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid balance");
                }
                else
                {
                    balance = value;
                }
            }
        }

        public string AccountType
        {
            get { return "Standard"; }
        }

        public BankAccount(string owner, double balance)
        {
            Owner = owner;
            Balance = balance;
        }

        public void Describe()
        {
            Console.WriteLine($"{owner} - {balance}TL - {AccountType}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount m = new BankAccount("LC", 50000);
            m.Describe();

            m.Balance = -500;
            m.Describe();

        }
    }
}