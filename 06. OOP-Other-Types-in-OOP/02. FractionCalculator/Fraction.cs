using System;

namespace _02.FractionCalculator
{
    public struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long numerator, long denominator): this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Numerator
        {
            get
            {
                return this.numerator;
                
            }

            private set
            {
                this.numerator = value;
                
            }
        }

        public long Denominator
        {
            get
            {
                return this.denominator;
                
            }

            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Denominator cannot be 0!");
                }
                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction fr1, Fraction fr2)
        {
            checked
            {
                var newNumeartor = checked((fr1.Numerator * fr2.Denominator) + (fr1.Denominator * fr2.Numerator));
                var newDenominator = checked(fr1.Denominator * fr2.Denominator);
                return new Fraction(newNumeartor, newDenominator);
            }
        }

        public static Fraction operator -(Fraction fr1, Fraction fr2)
        {
            checked
            {
                var newNumeartor = checked((fr1.Numerator * fr2.Denominator) - (fr1.Denominator * fr2.Numerator));
                var newDenominator = checked(fr1.Denominator * fr2.Denominator);
                return new Fraction(newNumeartor, newDenominator);
            }  
        }

        public override string ToString()
        {
            return ((decimal) this.Numerator/this.Denominator).ToString();
        }
    }
}
