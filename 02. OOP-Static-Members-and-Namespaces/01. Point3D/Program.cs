using System;
using _01.Point3D;

class Program
{
    static void Main()
    {
        Point3D point = new Point3D(1, 2, 3);

        Console.WriteLine(point);

        Console.WriteLine(Point3D.StartingPoint);
    }
}
