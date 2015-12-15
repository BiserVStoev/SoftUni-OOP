using _01.Shapes.Interfaces;

namespace _01.Shapes.Shapes
{
    public abstract class BasicShape: IShape
    {
        protected BasicShape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; set; }

        public double Height { get; set; }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }
}
