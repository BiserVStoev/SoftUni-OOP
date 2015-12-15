using System.Collections.Generic;
using _01.Point3D;

namespace _03.Paths
{
    public class Path3D
    {
        private List<Point3D> path;

        public Path3D(params Point3D[] points3D)
        {
            this.Path = new List<Point3D>();

            foreach (var point in points3D)
            {
                this.AddPoint3D(point);
            }
        }

        public List<Point3D> Path
        {
            get
            {
                return this.path;
            }

            private set
            {
                this.path = value;
            }
        }

        public void AddPoint3D(Point3D point)
        {
            this.Path.Add(point);
        }

        public override string ToString()
        {
            string result = "Path:\n";

            foreach (var point in this.Path)
            {
                result += "\t" + point + "\n";
            }

            return result;
        }
    }
}
