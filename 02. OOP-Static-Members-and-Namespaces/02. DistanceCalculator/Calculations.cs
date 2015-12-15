using System;
using _01.Point3D;
using _02.DistanceCalculator;

class Program
{
    static void Main()
    {
        double distance = DistanceCalculator.CalculateDistanceBetweenPoints(new Point3D(1, 15, 20),
            new Point3D(-3, 14, 0));

        Console.WriteLine(distance);
    }
}
