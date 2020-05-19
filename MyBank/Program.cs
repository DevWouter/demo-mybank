using System;
using System.Collections.Generic;

namespace MyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfAccounts = new List<BankAccount>();
            listOfAccounts.Add(new BankAccount());
            listOfAccounts.Add(new SavingsAccount());

            foreach (var account in listOfAccounts)
            {
                account.Deposit(500);
                (account as SavingsAccount)?.ApplyIntrest();
                account.Withdraw(700);

                Console.WriteLine(account);
            }

            // Console.ReadLine();  
        }
    }
}
