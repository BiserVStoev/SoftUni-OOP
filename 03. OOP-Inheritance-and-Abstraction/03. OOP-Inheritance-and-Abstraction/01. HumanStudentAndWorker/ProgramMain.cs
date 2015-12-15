using System;
using System.Collections;
using System.Linq;
using System.Runtime.InteropServices;

namespace _01.HumanStudentAndWorker
{
    using Models;
    using System.Collections.Generic;

    class ProgramMain
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student("Gosho", "Ivanov", "aa123gg1"),
                new Student("Petur", "Petrov", "1231241"),
                new Student("Ivana", "Donkich", "lol2lo"),
                new Student("Mariq", "Sarapova", "sadooo"),
                new Student("Toni", "BlazeIt", "12345"),
                new Student("Sado", "Juberov", "012345"),
                new Student("Misho", "Andreev", "sad012"),
                new Student("Pepi", "Petrova", "jojo223"),
                new Student("Aleks", "Gaushevichova", "988745"),
                new Student("Ivan", "Ivanov", "faknomer")
            };

            var sortedStudent = students.OrderBy(student => student.FacultyNumber);

            Console.WriteLine("Sorted students:");
            PrintCollection(sortedStudent);
            Console.WriteLine();

            List<Worker> workers = new List<Worker>
            {
                new Worker("Grigor", "Ivanov", 600m, 6),
                new Worker("Chavdar", "Petrov", 200m, 7),
                new Worker("Lisa", "Mon", 1000, 8),
                new Worker("Mariq", "Krisova", 150, 5),
                new Worker("Mani", "BlazeIt", 850, 6),
                new Worker("Sado", "Pushachov", 400, 4),
                new Worker("Misho", "Mishev", 150, 6),
                new Worker("Jaki", "Petrova", 350, 3),
                new Worker("Aleksis", "Gaushevichova", 1500, 8),
                new Worker("Mosho", "Ivanov", 1200, 6)
            };

            var sortedWorkers = workers.OrderBy(worker => worker.MoneyPerHour());

            Console.WriteLine("Sorted workers:");
            PrintCollection(sortedWorkers);
            Console.WriteLine();

            List<Human> studentsAndWorkers = new List<Human>();
            studentsAndWorkers.AddRange(students);
            studentsAndWorkers.AddRange(workers);

            var sortedHumans = studentsAndWorkers.OrderBy(human => human.FirstName).ThenBy(human => human.LastName);

            Console.WriteLine("Sorted humans:");
            PrintCollection(sortedHumans);


        }

        private static void PrintCollection(IEnumerable humans)
        {
            foreach (var human in humans)
            {
                Console.WriteLine(human);
            }
        }
    }
}
