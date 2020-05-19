using System;

namespace MyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new SavingsAccount();
            myAccount.Balance = 0;
            myAccount.Deposit(500);
            myAccount.Withdraw(200);

            Console.WriteLine(myAccount);
            // Console.ReadLine();  
        }
    }
}
