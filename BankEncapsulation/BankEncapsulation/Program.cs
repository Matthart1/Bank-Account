using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            Console.WriteLine("How much would you like to deposit?");
            double amountToDeposit = double.Parse(Console.ReadLine());
            account.Deposit(amountToDeposit);

            double userBalance = account.GetBalance();
            Console.WriteLine($"Your current account balance is {userBalance, 0:c}");
        }
    }
}
