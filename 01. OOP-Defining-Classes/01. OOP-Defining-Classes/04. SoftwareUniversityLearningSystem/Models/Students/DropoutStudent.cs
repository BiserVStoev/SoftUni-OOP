using System;
using _04.SoftwareUniversityLearningSystem.Interfaces;

namespace _04.SoftwareUniversityLearningSystem.Models.Students
{
    public class DropoutStudent: Student, IReapply
    {
        private string dropoutReason;

        public DropoutStudent(string firstName, string lastName, uint age, uint studentNumber, double averageGrade, string dropoutReason) : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.DropoutReason = dropoutReason;
        }

        public string DropoutReason
        {
            get
            {
                return this.dropoutReason;
                
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Dropout reason cannot be null or empty!");
                }

                this.dropoutReason = value;
            }
        }

        public void Reapply()
        {
            Console.WriteLine("{0}, dropout reason - {1}", base.ToString(), this.DropoutReason);
        }
    }
}
