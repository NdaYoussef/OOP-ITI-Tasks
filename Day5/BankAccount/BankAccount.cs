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


        public BankAccount(string name, double InitialBalance)
        {
            _accountHolder = name;
            _balance = InitialBalance;

            totalaccount++;

            InitialBalance += _totalBankBalance;
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


    }
}
