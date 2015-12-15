using _02.BankOfKurtovoKonare.Interfaces;

namespace _02.BankOfKurtovoKonare.Models
{
    public class DepositAccount: BaseAccount, IWithdrawable
    {
        public DepositAccount(ICustomer customer, decimal balance, double interestRate) : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Ballance < 1000 && this.Ballance > 0)
            {
                return base.CalculateInterest(0);
            }

            return base.CalculateInterest(months);
        }

        public void Withdraw(decimal amount)
        {
            this.Ballance -= amount;
        }
    }
}
