using System;
using _01.Point3D;

namespace _02.DistanceCalculator
{
    public class DistanceCalculator
    {
        public static double CalculateDistanceBetweenPoints(Point3D p1, Point3D p2)
        {
            double firstPair = Math.Pow(p1.X - p2.X, 2);
            double secondPair = Math.Pow(p1.Y - p2.Y, 2);
            double thirdPair = Math.Pow(p1.Z - p2.Z, 2);

            return Math.Sqrt(firstPair + secondPair + thirdPair);
        }
    }
}
