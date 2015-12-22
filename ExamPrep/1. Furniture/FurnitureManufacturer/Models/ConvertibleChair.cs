using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    public class ConvertibleChair: Chair, IConvertibleChair
    {
        private const decimal ConvertedHeight = 0.10m;

        private readonly decimal normalHeight;

        public ConvertibleChair(string model, string material, decimal price, decimal height, int numberOfLegs) : base(model, material, price, height, numberOfLegs)
        {
            this.normalHeight = Height;
            this.IsConverted = false;
        }

        public bool IsConverted { get; set; }

        public void Convert()
        {
            if (this.IsConverted)
            {
                this.Height = normalHeight;
                this.IsConverted = false;
            }
            else
            {
                this.Height = ConvertedHeight;
                this.IsConverted = true;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, State: {1}", base.ToString(), this.IsConverted ? "Converted" : "Normal");
        }
    }
}
