using System;
using _01.Point3D;
using _03.Paths;

class Program
{
    static void Main()
    {
        Path3D path = new Path3D(new Point3D(0, 1, 2), new Point3D(1.5, 2, -3.4), new Point3D(-3.1, 0, 4), Point3D.StartingPoint);
        path.AddPoint3D(new Point3D(0, -1, 1.1111111));
        Console.WriteLine(path);

        string fileLocation = "../../Path3D.txt";
        Storage.SavePath(fileLocation, path);

        Path3D pathFromFile;

        try
        {
            pathFromFile = Storage.LoadPath(fileLocation);
            Console.WriteLine(pathFromFile);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
