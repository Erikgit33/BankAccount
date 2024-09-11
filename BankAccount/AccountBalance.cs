using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class BankAccount
    {
        int balance;

        public void Deposit(int d)
        {
            balance += d;
        }

        public void Withdraw(int w)
        {   
            if (w <= balance)
            {
                balance -= w;
            }
        }
        
        public int GetBalance()
        {
            return balance;
        }
    }
}
