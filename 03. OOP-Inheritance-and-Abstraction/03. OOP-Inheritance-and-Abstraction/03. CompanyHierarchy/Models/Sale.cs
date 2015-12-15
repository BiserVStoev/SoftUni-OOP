using System;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy.Models
{
    public class Sale: ISale
    {
        private string saleName;
        private decimal price;

        public Sale(string saleName, decimal price, DateTime soldOn)
        {
            this.SaleName = saleName;
            this.Price = price;
            this.SoldOn = soldOn;
        }

        public string SaleName
        {
            get
            {
                return this.saleName;
                
            }

            set
            {
                if (value?.Trim().Length == 0)
                {
                    throw new ArgumentException("Name cannot be null or empty!");
                }

                this.saleName = value;
            }
        }

        public DateTime SoldOn { get; set; }

        public decimal Price
        {
            get
            {
                return this.price;
                
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Product: {0}, Price: {1}, Sold on: {2}", this.SaleName, this.Price, this.SoldOn);
        }
    }
}
