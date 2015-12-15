using System;
using _04.SoftwareUniversityLearningSystem.Interfaces;

namespace _04.SoftwareUniversityLearningSystem.Models.Trainers
{
    public class SeniorTrainer: Trainer, IDeleteCourse
    {
        public SeniorTrainer(string firstName, string lastName, uint age) : base(firstName, lastName, age)
        {
        }

        public void DeleteCourse(string name)
        {
            Console.WriteLine(@"Course ""{0}"" has been deleted!", name);
        }
    }
}
