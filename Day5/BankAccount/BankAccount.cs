using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class BankAccount
    {
        private string _accountHolder;
        private double _balance;
        private int _accountNumber;


        public static int totalaccount = 0;
        private static double _totalBankBalance = 0.0;

        public BankAccount()
        {

        }
        public BankAccount(string name, double InitialBalance)
        {
            _accountHolder = name;
            _balance = InitialBalance;

            totalaccount++;

            _totalBankBalance += InitialBalance;
        }


        public static void PrintBankSummary()
        {
            Console.WriteLine($"Total Accounts: {totalaccount}, Total Bank Balance: {_totalBankBalance}");
        }


        public static double GetAveragebalance()
        {

            double totalbalance = _totalBankBalance / totalaccount;
            if (totalaccount > 0)
            {
                Console.WriteLine($"Average balance per account: {totalbalance}");
                return totalbalance;
            }

            Console.WriteLine($"No accounts valid");
            return 0.0;
        }

        public string Deposit(double amount)
        {
            if (amount <= 0)
                return "Amount can't be zero or negative";

            _balance += amount;

            return $"added Balance = {_balance}";
        }

        public string Withdraw(double amount)
        {
            if (amount <= 0)
                return "Amount can't be zero or negative";

            if (amount > _balance)
                return "Insufficient Balance!";

            _balance -= amount;
            return $"New Balance = {_balance}";
        }


        public static BankAccount operator +(BankAccount a, BankAccount b)
        {

            BankAccount joint = new BankAccount();
            joint._accountHolder = a._accountHolder + b._accountHolder;
            Console.WriteLine($"result of add operator overloading of 2 objects :{joint._accountHolder}");

            joint._balance = a._balance + b._balance;
            Console.WriteLine($"Sum of total balance: {joint._balance} ");

            return joint;

            //Console.WriteLine($"Joint :{a._accountHolder} + & {b._accountHolder}");
        }

        public static bool operator >(BankAccount a, BankAccount b)
        {
            return (a._balance > b._balance);
        }

        public static bool operator <(BankAccount a, BankAccount b)
        {
            return a._balance < b._balance;
        }

        public static bool operator ==(BankAccount a, BankAccount b)
        { return a._accountNumber == b._accountNumber; }

        public static bool operator !=(BankAccount a, BankAccount b)
        { return a._accountNumber != b._accountNumber; }
    }


    //public override bool Equals(object obj)
    //    {
    //        if (obj is BankAccount other)
    //        {
    //            return this._balance == other._balance;
    //        }
    //        return false;
    //    }

    //    public override int GetHashCode()
    //    {
    //        return _balance.GetHashCode();
    //    }
    }
