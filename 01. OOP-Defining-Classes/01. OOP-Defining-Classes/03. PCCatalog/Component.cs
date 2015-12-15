using System;

namespace _03.PCCatalog
{
    class Component
    {
        private string name;
        private string details;
        private decimal price;

        public Component(string name, decimal price, string details)
        {
            this.Name = name;
            this.Details = details;
            this.Price = price;
        }

        public Component(string name, decimal price)
            : this(name, price, null)
        {
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Component name cannot be empty!");
                }
                this.name = value;
            }
        }

        public string Details
        {
            get
            {
                return this.details;
            }

            set
            {
                if (value != null && value.Trim().Length == 0)
                {
                    throw new ArgumentException("Component details cannot be blank!");
                }
                this.details = value;
            }
        }

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
                    throw new ArgumentException("Price cannot be negative!");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(this.Details))
            {
                return string.Format("Component name: {0}, Component price: {1} BGN", this.Name, this.Price);
            }

            return string.Format("Component name: {0}, Component price: {1} BGN, Details: {2}", this.Name, this.Price, this.Details);
            
        }
    }
}
