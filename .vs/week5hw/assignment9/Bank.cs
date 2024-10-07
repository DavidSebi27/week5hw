using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment9
{
    internal class Bank
    {
        public BankAccount[] bankAccounts;
        public int count;

        public Bank(int capacity)
        {
            bankAccounts = new BankAccount[capacity];
            count = 0;
        }

        public void CreateAccount(string accountHolder)
        {
            
        }
    }
}
