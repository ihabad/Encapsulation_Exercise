using System;
using System.Dynamic;

namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            Console.WriteLine("What amount would you like to deposit today?");

            var amountToDeposit = double.Parse(Console.ReadLine());

            Console.WriteLine("Thank you");

            account.Deposit(amountToDeposit);
            Console.WriteLine($"Your total bank account balance is now! {account.GetBalance()}$");
        }
    }
}
