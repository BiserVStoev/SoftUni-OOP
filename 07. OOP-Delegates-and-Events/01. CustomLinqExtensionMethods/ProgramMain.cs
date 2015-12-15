using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CustomLinqExtensionMethods
{
    class ProgramMain
    {
        static void Main()
        {
            Console.WriteLine("Odd integers:");

            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            list
                .WhereNot(e => e % 2 == 0)
                .ToList()
                .ForEach(Console.WriteLine);

            Console.Write("Max: ");
            Console.WriteLine(list.Maximum(i => i));

            Console.WriteLine();

            var students = new List<Student>
            {
                new Student ("Pesho", 20),
                new Student ("Gosho", 22),
                new Student("Ivan", 19)
            };

            Console.Write("Student maximum age: ");
            Console.WriteLine(students.Maximum(s => s.Age));
        }
    }
}
