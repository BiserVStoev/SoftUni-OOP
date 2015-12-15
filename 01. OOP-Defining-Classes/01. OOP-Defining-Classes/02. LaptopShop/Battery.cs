
using System;

namespace _02.LaptopShop
{
    public class Battery
    {
        private string brand;
        private int cells;
        private int power;

        public Battery(string brand, int cells, int power)
        {
            this.Brand = brand;
            this.Cells = cells;
            this.Power = power;
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The battery brand cannot e empty");
                }

                this.brand = value;
            }
        }

        public int Cells
        {
            get
            {
                return this.cells;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The cells cannot be negative");
                }

                this.cells = value;
            }
        }

        public int Power
        {
            get
            {

                return this.power;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The battery power cannot be negative");
                }

                this.power = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}-cells, {2}mAh", this.Brand, this.Cells, this.Power);
        }
    }
}
