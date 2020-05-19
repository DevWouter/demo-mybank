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

            ((SavingsAccount)myAccount).ApplyIntrest();

            var moneyReceived = myAccount.Withdraw(700);
            Console.WriteLine("Withdrawn: " + moneyReceived);

            Console.WriteLine(myAccount);
            // Console.ReadLine();  
        }
    }
}
