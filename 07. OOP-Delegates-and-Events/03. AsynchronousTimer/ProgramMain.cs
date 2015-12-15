using System;

namespace _03.AsynchronousTimer
{
    class ProgramMain
    {
        static void Main()
        {
            var async = new AsynchronousTimer(Console.WriteLine, 10, 1000, "420!");
            async.Run();
        }
    }
}
