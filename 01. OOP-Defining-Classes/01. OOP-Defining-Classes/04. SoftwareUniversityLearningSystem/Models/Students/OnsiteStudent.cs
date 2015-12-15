namespace _04.SoftwareUniversityLearningSystem.Models.Students
{
    public class OnsiteStudent: CurrentStudent
    {
        public OnsiteStudent(string firstName, string lastName, uint age, uint studentNumber, double averageGrade, string currentCourse, uint numberOfVisits) : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
        {
            this.NumberOfVisits = numberOfVisits;
        }

        public uint NumberOfVisits { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, number of visits - {1}", base.ToString(), this.NumberOfVisits);
        }
    }
}
