using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using _01.Point3D;

namespace _03.Paths
{
    public static class Storage
    {
        public static Path3D LoadPath(string source)
        {
            StreamReader reader = null;

            try
            {
                reader = new StreamReader(source);
            }
            catch (FileNotFoundException)
            {
                throw new ArgumentException("File not found");
            }

            List<Point3D> points = new List<Point3D>();

            using (reader)
            {
                while (true)
                {
                    string line = reader.ReadLine();

                    if (string.IsNullOrEmpty(line))
                    {
                        break;
                    }
                    double[] coordinates = line.Split(' ').Select(double.Parse).ToArray();
                    double x = coordinates[0];
                    double y = coordinates[1];
                    double z = coordinates[2];
                    points.Add(new Point3D(x, y, z));
                }
                Path3D pathFromFile = new Path3D(points.ToArray());
                return pathFromFile;
            }
        }

        public static void SavePath(string destination, Path3D path)
        {
            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(destination);
            }
            catch (Exception)
            {
                throw new DirectoryNotFoundException("Directory not found");
            }
            using (writer)
            {
                using (writer)
                {
                    foreach (Point3D point in path.Path)
                    {
                        writer.WriteLine("{0} {1} {2}", point.X, point.Y, point.Z);
                    }
                }
            }
        }
    }
}
