using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment9
{
    internal class BankAccount
    {
        public string HolderName;
        public double Balance = 0;

        public BankAccount(string holderName, int initialBalance)
        {
            HolderName = holderName;
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited {amount:C} into {HolderName}'s account.");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

    }
}
