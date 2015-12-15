using System;

namespace _02.InterestCalculator
{
    public delegate double CalculateInterest(double sum, double interest, int years);

    public class InterestCalculator
    {
        private readonly CalculateInterest interestdelegate;

        private double sum;
        private double interest;
        private int years;

        public InterestCalculator(
            double sum,
            double interest,
            int years,
            CalculateInterest interestdelegate)
        {
            this.Sum = sum;
            this.Interest = interest;
            this.Years = years;
            this.interestdelegate = interestdelegate;
        }

        private double Sum
        {
            get
            {
                return this.sum;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Sum cannot be negative!");
                }

                this.sum = value;
            }
        }

        private double Interest
        {
            get
            {
                return this.interest;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest cannot be negative!");
                }

                this.interest = value;
            }
        }

        private int Years
        {
            get
            {
                return this.years;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Years cannot be negative!");
                }
                this.years = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0:F4}", this.interestdelegate(this.Sum, this.Interest, this.Years));
        }

    }
}
