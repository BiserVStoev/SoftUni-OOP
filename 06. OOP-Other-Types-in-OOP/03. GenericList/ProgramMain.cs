using System;

namespace _03.GenericList
{
    class ProgramMain
    {
        static void Main()
        {
            GenericList<string> names = new GenericList<string>();
            names.Add("Pesho");
            names.Add("Mesho");
            names.Add("Gosho");
            names.Add("Tosho");
            names.Add("Alex");
            names.Add("Misho");
            names.Insert("Pepi", 0);

            Console.WriteLine("Generic list size: {0}", names.Size());
            Console.WriteLine(@"Names contains ""gosho"": {0}", names.Contains("Gosho"));
            Console.WriteLine("Min: {0}", names.Min());
            Console.WriteLine("Max: {0}", names.Max());
            Console.WriteLine(@"Index of ""Pesho"": {0}", names.IndexOf("Pesho"));
            Console.WriteLine(names);

            Console.WriteLine();

            GenericList<int> numbers = new GenericList<int>();
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(18);
            numbers.Add(9);
            numbers.Add(3);
            numbers.Add(-14);
            numbers.Insert(15, 4);
            numbers.Remove(3);

            Console.WriteLine("Generic list size: {0}", numbers.Size());
            Console.WriteLine(@"Numbers contains ""242"": {0}", numbers.Contains(242));
            Console.WriteLine("Min: {0}", numbers.Min());
            Console.WriteLine("Max: {0}", numbers.Max());
            Console.WriteLine(@"Index of ""Pesho"": {0}", numbers.IndexOf(18));
            Console.WriteLine(numbers);

            Console.WriteLine();

            numbers.Clear();

            Console.WriteLine(@"Numbers after clearing : {0}", (numbers.Size() > 0) ? numbers.ToString() : "empty");
        }
    }
}
