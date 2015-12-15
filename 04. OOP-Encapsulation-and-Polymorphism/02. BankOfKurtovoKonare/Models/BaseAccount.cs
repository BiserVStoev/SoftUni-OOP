using System;
using _02.BankOfKurtovoKonare.Interfaces;

namespace _02.BankOfKurtovoKonare.Models
{
    public abstract class BaseAccount: IAccount
    {
        private ICustomer customer;
        private double monthlyInterestRate;

        protected BaseAccount(ICustomer customer, decimal balance, double interestRate)
        {
            this.Customer = customer;
            this.Ballance = balance;
            this.InterestRate = interestRate;
        }

        public ICustomer Customer
        {
            get
            {
                return this.customer;
                
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("customer", "Customer cannot be empty.");
                }

                this.customer = value;
            }
        }

        public decimal Ballance { get; protected set; }

        public double InterestRate
        {
            get
            {
                return this.monthlyInterestRate; 
                
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("monthlyInterestRate", "The monthly interest rate cannot be negative.");
                }

                this.monthlyInterestRate = value;
            }
        }

        public virtual decimal CalculateInterest(int months)
        {
            return this.Ballance*(1 + (decimal) this.InterestRate*months);
        }

        public void Deposit(decimal amount)
        {
            this.Ballance += amount;
        }
    }
}
