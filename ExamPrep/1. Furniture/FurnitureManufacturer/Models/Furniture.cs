using System;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    public abstract class Furniture: IFurniture
    {
        private const int ModelMinLength = 3;
        private const string ModelLengthMessage = "Model must be atleast {0} symbols long!";

        private string model;
        private string material;
        private decimal price;
        private decimal height;

        protected Furniture(string model, string material, decimal price, decimal height)
        {
            this.Model = model;
            this.Material = material;
            this.Price = price;
            this.Height = height;
        }

        public string Model
        {
            get
            {
                return this.model;     
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Model cannot be null or empty!");
                }

                if (value.Trim().Length < ModelMinLength)
                {
                    throw new ArgumentException(string.Format(ModelLengthMessage, ModelMinLength));
                }

                this.model = value;
            }
        }

        public string Material { get; set; }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value <= 0.00m)
                {
                    throw new ArgumentException("Price cannot be zero or negative!");
                }

                this.price = value;
            }
        }

        public decimal Height
        {
            get
            {
                return this.height;   
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height cannot be negative!");
                }

                this.height = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}", this.GetType().Name,
                this.Model, this.Material, this.Price, this.Height);
        }
    }
}
