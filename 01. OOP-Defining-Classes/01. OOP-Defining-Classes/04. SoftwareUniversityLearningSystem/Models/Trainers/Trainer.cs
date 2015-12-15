using System;
using _04.SoftwareUniversityLearningSystem.Interfaces;

namespace _04.SoftwareUniversityLearningSystem.Models.Trainers
{
    public abstract class Trainer: Person, ICreateCourse
    {
        protected Trainer(string firstName, string lastName, uint age) : base(firstName, lastName, age)
        {
        }

        public void CreateCourse(string name)
        {
            Console.WriteLine(@"Course ""{0}"" has been created!", name);
        }
    }
}
