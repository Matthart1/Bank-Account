using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    class BankAccount
    {
        private double _balance;
        public void Deposit(double amount)
        {
            Console.WriteLine($"Your money in the amount of {amount, 0:c} is being deposited");
            _balance = amount;

        }
        public double GetBalance()
        {
            return _balance;
        }
    }
}
