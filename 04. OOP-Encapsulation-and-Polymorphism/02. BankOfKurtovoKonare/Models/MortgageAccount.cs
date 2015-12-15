using _02.BankOfKurtovoKonare.Interfaces;

namespace _02.BankOfKurtovoKonare.Models
{
    public class MortgageAccount: BaseAccount
    {
        public MortgageAccount(ICustomer customer, decimal balance, double interestRate) : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Customer.CustomerType == CustomerType.Individual && months <= 6)
            {
                return base.CalculateInterest(months)/2;
            }

            if (this.Customer.CustomerType == CustomerType.Company && months <= 12)
            {
                return base.CalculateInterest(months) / 2;
            }

            return base.CalculateInterest(months);
        }
    }
}
