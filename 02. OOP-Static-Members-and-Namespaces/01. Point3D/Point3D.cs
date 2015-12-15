using System.Runtime.CompilerServices;

namespace _01.Point3D
{
    public class Point3D
    {
        private double x;
        private double y;
        private double z;

        private static readonly Point3D StartingPointCoordinates;

        static Point3D()
        {
            StartingPointCoordinates = new Point3D(0, 0, 0);
        }

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        public static Point3D StartingPoint
        {
            get { return StartingPointCoordinates; }
        }

        public override string ToString()
        {
            return string.Format(@"{{{0}, {1}, {2}}}", this.X, this.Y, this.Z);
        }
    }
}
