using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class BankAccount
    {
        string AccountNumber;  // { get; set; }
         string AccountHolderName;// { get; set; }
         double Balance;// { get; set; }
         bool IsActive = false;

        public string SetAccountNumber (string accountNumber)
        {
            if (accountNumber == null)
                return "You must enter Account Number";


            if (accountNumber.Length != 8)
                return "Enter only 8 characters for account number!";

            AccountNumber =  accountNumber;
            IsActive = true;
            return AccountNumber;

        }

        public string SetAccountHolderName(string name)
        {
            if (string.IsNullOrEmpty(name))
                return "please enter correct value, name can't be null or empty";

            AccountHolderName = name;
            
            return AccountHolderName;
        }

        public string GetAccountHolderName()
        {
            return AccountHolderName;
        }

        public double GetBalance()
        {
            return Balance;
        }

        public bool IsAccountActive()
        {
            return IsActive ;
        }

        public string Deposit(double amount)
        {
            if (amount <= 0)
                return "Amount can't be zero or negative";

           Balance += amount;
            
            return $"added Balance = {Balance}";
        }

        public string Withdraw(double amount)
        {
            if (amount <= 0)
                return "Amount can't be zero or negative";

            if (amount > Balance)
                return "Insufficient Balance!" ;

            Balance -= amount;
            return $"New Balance = {Balance}";
        }

        public bool ActivateAccount()
        {
            return IsActive = true;
        }

        public bool DeactivateAccount()
        {
            return IsActive = false;
        }

        public string DispleyAccountInfo()
        {
           return ($"Account Nmuber = {AccountNumber}, Holder Name = {AccountHolderName}, Account Balacne = {Balance}, Status = {IsActive}");

        }

    }
}
