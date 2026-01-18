namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
//            Console.WriteLine("Hello, World!");


            BankAccount account1 = new BankAccount("Nda", 1500);
            BankAccount account2 = new BankAccount("Youssef",3000);

            
           
            Console.WriteLine($"Added amount for acc1: {account1.Deposit(200.15)}");
            Console.WriteLine($"Added amount for acc1: {account2.Deposit(3400)}");


            //   Console.WriteLine($"Total summary about first account: {}");

            BankAccount.PrintBankSummary();
            BankAccount.GetAveragebalance();



            BankAccount bankAccount = new BankAccount();
            bankAccount(account1 + account2);

        }
    }
}
