using System;
using System.Text;

namespace _02.LaptopShop
{
    public class Laptop
    {
        private string model;
        private decimal price;
        private string manufacturer;
        private string processor;
        private string ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private double batteryLife;
        private Battery battery;

        public Laptop(string model, decimal price, string manufacturer, string processor, string ram, string graphicsCard, string hdd, string screen, Battery battery, double batteryLife)
        {
            this.Model = model;
            this.Price = price;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.HDD = hdd;
            this.Screen = screen;
            this.Battery = battery;
            this.BatteryLife = batteryLife;
        }

        public Laptop(string model, decimal price)
            : this(model, price, null, null, null, null, null, null, null, 0)
        {
            
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (value != null && value.Trim().Length == 0)
                {
                    throw new ArgumentException("Model cannot be empty!");
                }

                this.model = value;
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

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            set
            {
                if (value != null && value.Trim().Length == 0)
                {
                    throw new ArgumentException("Manufacturer cannot be empty!");
                }

                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get
            {
                return this.processor;
            }

            set
            {
                if (value != null && value.Trim().Length == 0)
                {
                    throw new ArgumentException("Processor cannot be empty!");
                }

                this.processor = value;
            }
        }

        public string Ram
        {
            get
            {
                return this.ram;
            }

            set
            {
                if (value != null && value.Trim().Length == 0)
                {
                    throw  new ArgumentException("Ram cannot be empty!");
                }

                this.ram = value;
            }
        }

        public string GraphicsCard
        {
            get
            {
                return this.graphicsCard;
            }
            set
            {
                if (value != null && value.Trim().Length == 0)
                {
                    throw new ArgumentException("Graphic card cannot be empty!");
                }

                this.graphicsCard = value;
            }
        }

        public string HDD
        {
            get
            {
                return this.hdd;
            }

            set
            {
                if (value != null && value.Trim().Length == 0)
                {
                    throw new ArgumentException("HDD cannot be empty!");
                }

                this.hdd = value;
            }
        }

        public string Screen
        {
            get
            {
                return this.screen;
            }

            set
            {
                if (value != null && value.Trim().Length == 0)
                {
                    throw new ArgumentException("Screen cannot be empty!");
                }

                this.screen = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return battery;
            }

            set
            {
                this.battery = value;
            }
        }

        public double BatteryLife
        {
            get
            {
                return this.batteryLife;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Battery life cannot be negative");
                }

                this.batteryLife = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("Model: {0}", this.Model));

            if (!string.IsNullOrEmpty(this.Manufacturer))
            {
                sb.AppendLine(string.Format("Manufacturor: {0}", this.Manufacturer));
            }

            if (!string.IsNullOrEmpty(this.Processor))
            {
                sb.AppendLine(string.Format("Processor: {0}", this.Processor));
            }

            if (!string.IsNullOrEmpty(this.Ram))
            {
                sb.AppendLine(string.Format("Ram: {0}", this.Ram));
            }

            if (!string.IsNullOrEmpty(this.GraphicsCard))
            {
                sb.AppendLine(string.Format("Graphics card: {0}", this.GraphicsCard));
            }

            if (!string.IsNullOrEmpty(this.HDD))
            {
                sb.AppendLine(string.Format("HDD: {0}", this.HDD));
            }

            if (!string.IsNullOrEmpty(this.Screen))
            {
                sb.AppendLine(string.Format("Screen: {0}", this.Screen));
            }

            if (this.Battery != null)
            {
                sb.AppendLine(string.Format("Battery: {0}", this.Battery));
            }

            if (this.BatteryLife > 0)
            {
                sb.AppendLine(string.Format("Battery life: {0:0.0} hours", this.BatteryLife));
            }

            sb.AppendLine(string.Format("Price: {0:0.00}lv", this.Price));

            return sb.ToString();
        }
    }
}
