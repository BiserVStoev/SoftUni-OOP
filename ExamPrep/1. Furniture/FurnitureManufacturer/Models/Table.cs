using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    public class Table: Furniture, ITable
    {
        public Table(string model, string material, decimal price, decimal height, decimal length, decimal width) : base(model, material, price, height)
        {
            this.Length = length;
            this.Width = width;
        }

        public decimal Length { get; }
        public decimal Width { get; }

        public decimal Area
        {
            get { return this.Length*this.Width; }
        }

        public override string ToString()
        {
            return string.Format("{0}, Length: {1}, Width: {2}, Area: {3}", base.ToString(), this.Length, this.Width,
                this.Area);
        }
    }
}
