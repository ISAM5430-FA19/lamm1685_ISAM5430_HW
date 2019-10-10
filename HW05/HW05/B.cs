using System;
using static System.Console;
namespace B
{
    class Account
    {
        public string Name { get; set; }
        private decimal balance;
        public Account(string acctname, decimal initbalance)
        {
            Name = acctname;
            Balance = initbalance;
        }
        public decimal Balance
        {
            private set
            {
                if (value > 0.0m) balance = value;
            }
            get
            {
                return balance;
            }
        }
        public void Deposit(decimal depositamount)
        {
            if (depositamount > 0.0m)
            {
                Balance += depositamount;
            }
        }
        public void Withdrawal(decimal withdrawamount)
        {
            if (withdrawamount > 0.0m && withdrawamount <= balance)
            {
                Balance -= withdrawamount;
            }

        }
    }

    class Accounttest
    {
        static void Main()
        {
            Account acct1 = new Account("Ginger",100.00m);
            Account acct2 = new Account("Lemongrass", 80.50m);
            WriteLine($"Account 1 is {acct1.Name} with balance of {acct1.Balance:C}");
            WriteLine($"Account 2 is {acct2.Name} with balance of {acct2.Balance:C}");

            Write("Amount deposit to account 1: ");
            decimal depamount = decimal.Parse(ReadLine());
            acct1.Deposit(depamount);

            Write("Amount deposit to account 2: ");
            depamount = decimal.Parse(ReadLine());
            acct2.Deposit(depamount);
            WriteLine("After deposit:");
            WriteLine($"Account 1 is {acct1.Name} with balance of {acct1.Balance:C}");
            WriteLine($"Account 2 is {acct2.Name} with balance of {acct2.Balance:C}");

            Write("Amount withdraw from account 1: ");
            decimal wamount = decimal.Parse(ReadLine());
            acct1.Withdrawal(wamount);

            Write("Amount withdraw from account 2: ");
            wamount = decimal.Parse(ReadLine());
            acct2.Withdrawal(wamount);
            WriteLine("After withdrawal: ");
            WriteLine($"Account 1 is {acct1.Name} with balance of {acct1.Balance:C}");
            WriteLine($"Account 2 is {acct2.Name} with balance of {acct2.Balance:C}");

        }
    }
}
