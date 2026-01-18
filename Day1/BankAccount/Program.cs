namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region acc01
            //BankAccount account = new BankAccount();


            ////Info foe acc1
            //account.SetAccountNumber("12345678");
            //account.SetAccountHolderName("Nda");



           // string addedAmount = account.Deposit(500);
           // Console.WriteLine($"New Amount Added : {addedAmount}");

           // string withdrawnAmount = account.Withdraw(300);
           // Console.WriteLine($"Withdrawn Amount :  {withdrawnAmount}");

           // string firstAccounInfo = account.DispleyAccountInfo() ;
           //Console.WriteLine($"Account Info : {firstAccounInfo}");

           // Console.WriteLine($"First Account status is : {account.ActivateAccount()}");

           // Console.WriteLine( $"First Account status is : {account.DeactivateAccount()}" );
            #endregion


            // Console.WriteLine("Hello, World!");


            BankAccount account2 = new BankAccount();


            //Info for acc2
            account2.SetAccountNumber("87654321");
            account2.SetAccountHolderName("Youssef");



            //string secondAccounInfo = account2.DispleyAccountInfo();
            //Console.WriteLine($"Account Info : {secondAccounInfo}");

            string addedAmount = account2.Deposit(500);
            Console.WriteLine($"New Amount Added : {addedAmount}");

            //withdrawnAmount = account.Withdraw(300);
            //Console.WriteLine($"Withdrawn Amount :  {withdrawnAmount}");

            //Console.WriteLine($"Second Account status is : {account2.ActivateAccount()}");

            //Console.WriteLine($"Second Account status is : {account2.DeactivateAccount()}");
        }
    }
}
