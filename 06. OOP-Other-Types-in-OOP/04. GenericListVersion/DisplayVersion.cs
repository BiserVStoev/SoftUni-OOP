using System;
using System.Linq;
using _03.GenericList;

namespace _04.GenericListVersion
{
    class DisplayVersion
    {
        static void Main()
        {
            typeof(GenericList<>).GetCustomAttributes(false)
                .OfType<VersionAttribute>()
                .ToList()
                .ForEach(p => Console.WriteLine(p.Version));
        }
    }
}
