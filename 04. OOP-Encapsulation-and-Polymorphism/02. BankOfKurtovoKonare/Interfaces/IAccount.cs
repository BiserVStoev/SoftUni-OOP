using _02.BankOfKurtovoKonare.Models;

namespace _02.BankOfKurtovoKonare.Interfaces
{
    public interface IAccount: IDepositable
    {
        ICustomer Customer { get; set; }

        decimal Ballance { get; }

        double InterestRate { get; set; }

        decimal CalculateInterest(int months);
    }
}
