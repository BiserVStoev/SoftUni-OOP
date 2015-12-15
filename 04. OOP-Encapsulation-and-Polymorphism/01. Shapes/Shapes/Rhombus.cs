using System;

namespace _01.Shapes.Shapes
{
    public class Rhombus: BasicShape
    {
        public Rhombus(double width, double height) : base(width, height)
        {
        }

        public override double CalculateArea()
        {
            return (this.Width*this.Height)/2;
        }

        public override double CalculatePerimeter()
        {
            return this.CalculateRhombusSide()*4;
        }

        private double CalculateRhombusSide()
        {
            return (Math.Sqrt((this.Width*this.Width) + (this.Height*this.Height))) / 2;
        }
    }
}
