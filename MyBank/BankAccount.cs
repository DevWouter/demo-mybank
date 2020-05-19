using System;
using System.Collections.Generic;
using System.Text;

namespace MyBank
{
    class BankAccount
    {
        public int Balance { get; set; }

        public void Deposit(int amount)
        {
            Balance += amount;
        }

        public virtual int Withdraw(int amount)
        {
            Balance -= amount;
            return amount;
        }

        public override string ToString()
        {
            return "Balance is " + Balance;
        }
    }

    class SavingsAccount : BankAccount
    {
        public override int Withdraw(int amount)
        {
            if (amount > Balance)
            {
                throw new Exception("You are overdrafting your savings account");
            }

            return base.Withdraw(amount);
        }
    }
}
