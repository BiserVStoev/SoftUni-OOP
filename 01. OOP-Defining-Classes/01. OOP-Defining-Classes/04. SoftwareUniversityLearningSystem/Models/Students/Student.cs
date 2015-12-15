using System;

namespace _04.SoftwareUniversityLearningSystem.Models.Students
{
    abstract public class Student: Person
    {
        private double averageGrade;
        
        protected Student(string firstName, string lastName, uint age, uint studentNumber, double averageGrade) : base(firstName, lastName, age)
        {
            this.StudentNumber = studentNumber;
            this.AverageGrade = averageGrade;
        }

        public uint StudentNumber { get; set; }

        public double AverageGrade
        {
            get
            {
                return this.averageGrade;
                
            }

            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Average grade cannot be negative");
                }

                this.averageGrade = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, average grade - {1}", base.ToString(), this.AverageGrade);
        }
    }
}
