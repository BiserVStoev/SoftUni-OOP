using ISIS.Core;
using ISIS.Core.Factory;
using ISIS.Interfaces;
using ISIS.IO;

namespace ISIS
{
    class ProgramMain
    {
        static void Main()
        {
            var writer = new ConsoleWriter();
            var reader = new ConsoleReader();
            var factory = new GroupFactory();

            IRunnable engine = new Engine(reader, writer, factory);

            engine.Run();
        }
    }
}
