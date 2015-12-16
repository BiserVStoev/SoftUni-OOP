using System;

namespace _03.StringDisperser
{
    class ProgramMain
    {
        static void Main()
        {
            StringDisperser stringDisperser = new StringDisperser("gosho", "pesho", "tanio");
            foreach (var ch in stringDisperser)
            {
                Console.Write(ch + " ");
            }

            StringDisperser stringDisperser2 = new StringDisperser("ivan");

            Console.WriteLine();
            
            Console.WriteLine(stringDisperser.Equals(stringDisperser2));
            Console.WriteLine(stringDisperser != stringDisperser2);
            Console.WriteLine(stringDisperser == stringDisperser2);

            Console.WriteLine();

            Console.WriteLine(stringDisperser.CompareTo(stringDisperser2));

            StringDisperser stringDisperser3 = stringDisperser2.Clone() as StringDisperser;

            Console.WriteLine(stringDisperser3);
        }
    }
}
