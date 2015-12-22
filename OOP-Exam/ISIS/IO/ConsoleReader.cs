using System;
using ISIS.Interfaces;

namespace ISIS.IO
{
    public class ConsoleReader: IInputReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
