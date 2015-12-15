using System;
using System.Collections.Generic;
using _01.Shapes.Interfaces;
using _01.Shapes.Shapes;

namespace _01.Shapes
{
    class ProgramMain
    {
        static void Main()
        {
            List<IShape> shapes = new List<IShape>
            {
                new Rectangle(25.6, 46.3),
                new Circle(.33),
                new Rectangle(1, 2),
                new Circle(5.6),
                new Rhombus(16.66, 78),
                new Circle(25.6),
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("Type: {0}, perimeter: {1:F1}, area: {2:F2}", shape.GetType().Name, shape.CalculatePerimeter(), shape.CalculateArea());
            }
        }
    }
}
