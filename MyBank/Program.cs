using System;
using System.Collections.Generic;

namespace MyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfAccounts = new List<BankAccount>();

            BankAccount myAccount = new SavingsAccount();
            myAccount.Balance = 0;
            myAccount.Deposit(500);

            (myAccount as SavingsAccount)?.ApplyIntrest();

            var moneyReceived = myAccount.Withdraw(700);
            Console.WriteLine("Withdrawn: " + moneyReceived);

            Console.WriteLine(myAccount);
            // Console.ReadLine();  
        }
    }
}
