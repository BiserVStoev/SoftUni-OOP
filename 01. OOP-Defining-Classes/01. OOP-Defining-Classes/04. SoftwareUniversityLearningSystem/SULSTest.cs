using System;
using System.Collections.Generic;
using System.Linq;
using _04.SoftwareUniversityLearningSystem.Models;
using _04.SoftwareUniversityLearningSystem.Models.Students;
using _04.SoftwareUniversityLearningSystem.Models.Trainers;

namespace _04.SoftwareUniversityLearningSystem
{
    class SULSTest
    {
        static void Main()
        {
            List<Person> people = new List<Person>
            {
                new JuniorTrainer("Ivan", "Ivanov", 31),
                new SeniorTrainer("Pesho", "Dimitrov", 31),
                new GraduateStudent("Dimitar", "Dimitrov", 24, 141135, 4.5),
                new DropoutStudent("Mariq", "Petrova", 22, 151123, 2.5, "Low grades"),
                new OnlineStudent("Misho", "Mishev", 23, 112334, 3.99, "Informatics"),
                new OnsiteStudent("Anjela", "Petrova", 30, 123419, 5.2, "Design", 20),
                new OnsiteStudent("Koi", "Djordjano", 22, 123413, 6, "Economics", 10),
                new OnsiteStudent("Anjela", "Mihailova", 30, 123411, 5, "Design", 15),
                new OnsiteStudent("Petar", "Stoyanov", 80, 977547, 2.01, "C# Basic", 1),
                new OnlineStudent("Ivaylo", "Tokiev", 33, 895477, 4.90, "OOP")
            };

            people.Where(student => student is CurrentStudent).OrderBy(student => ((Student)student).AverageGrade).ToList().ForEach(Console.WriteLine);

            Console.WriteLine();

            SeniorTrainer seniorTrainer = new SeniorTrainer("Gosho", "Goshev", 15);
            seniorTrainer.DeleteCourse("Sports");
            seniorTrainer.CreateCourse("Gymnastics");
            Console.WriteLine(seniorTrainer);

            Console.WriteLine();

            DropoutStudent dropoutStudent = new DropoutStudent("Pencho", "Kenev", 20, 125123, 2, "Bad behaviour");
            dropoutStudent.Reapply();

            Console.WriteLine();

            OnsiteStudent onsiteStudent = new OnsiteStudent("Anjela", "Petrova", 30, 123419, 5.2, "Design", 20);
            Console.WriteLine(onsiteStudent);
        }
    }
}
