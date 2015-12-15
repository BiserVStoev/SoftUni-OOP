using System;

namespace _04.SoftwareUniversityLearningSystem.Models.Students
{
    public abstract class CurrentStudent: Student
    {
        private string currentCourse;

        protected CurrentStudent(string firstName, string lastName, uint age, uint studentNumber, double averageGrade, string currentCourse) : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.CurrentCourse = currentCourse;
        }

        public string CurrentCourse
        {
            get
            {
                return this.currentCourse;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Current course cannot be null or empty!");
                }

                this.currentCourse = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, current course - {1}", base.ToString(), this.CurrentCourse);
        }
    }
}
