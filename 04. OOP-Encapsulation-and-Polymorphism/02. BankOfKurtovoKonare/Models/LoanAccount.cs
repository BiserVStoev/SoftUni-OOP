using _02.BankOfKurtovoKonare.Interfaces;

namespace _02.BankOfKurtovoKonare.Models
{
    public class LoanAccount : BaseAccount
    {

        public LoanAccount(ICustomer customer, decimal balance, double interestRate) : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Customer.GetType().Name == "IndividualCustomer" && months <= 3)
            {
                return base.CalculateInterest(0);
            }
            else if (this.Customer.GetType().Name == "CompanyCustomer" && months <= 2)
            {
                return base.CalculateInterest(0);
            }

            return base.CalculateInterest(months);
        }
    }
}
