using System;
using _02.BankOfKurtovoKonare.Interfaces;
using _02.BankOfKurtovoKonare.Models;

namespace _02.BankOfKurtovoKonare
{
    class ProgramMain
    {
        static void Main()
        {
            IAccount[] accounts =
            {
                new DepositAccount(new Customer("Ivan", CustomerType.Individual), 1050.25m, 0.0055),
                new LoanAccount(new Customer("TBP", CustomerType.Company), -10000, 0.0005),
                new MortgageAccount(new Customer("Pesho", CustomerType.Individual), -50000, 0.0011),
                new DepositAccount(new Customer("ASWA", CustomerType.Company), 1000000, 0.00075),
            };

            foreach (var account in accounts)
            {
                Console.WriteLine("Type of account: {0}, balance: {1:c2}, rate: {2:f3}%, interest after 4 months: {3:c2}", account.GetType().Name, account.Ballance, account.InterestRate, account.CalculateInterest(4));
            }
        }
    }
}
