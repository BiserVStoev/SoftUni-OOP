namespace _02.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Models;

    internal class ProgramMain
    {
        private static void Main()
        {
            List<Animal> animals = new List<Animal>
            {
                new Tomcat("Tom", 3),
                new Kitten("Darsi", 5),
                new Dog("Roni", 18, "Male"),
                new Tomcat("Rosi", 13),
                new Frog("Skoki", 2, "Male"),
                new Dog("Sharo", 13, "Male"),
                new Frog("Joro", 1, "Male"),
                new Frog("Dani", 3, "Female"),
                new Tomcat("Roshko", 5),
                new Dog("Boni", 4, "Female")
            };

            animals
                .GroupBy(animal => animal.GetType().Name)
                .Select(group => new
                {
                    AnimalName = group.Key,
                    AverageAge = group.Average(a => a.Age)
                })
                .OrderBy(group => group.AverageAge)
                .ToList()
                .ForEach(
                    group =>
                        Console.WriteLine("{0}'s average is: {1}", group.AnimalName, (int)group.AverageAge));
        }
    }
}
