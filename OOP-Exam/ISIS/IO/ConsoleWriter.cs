using System;
using ISIS.Interfaces;

namespace ISIS.IO
{
    public class ConsoleWriter: IOutputWriter
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
