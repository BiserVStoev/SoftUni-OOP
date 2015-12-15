namespace _04.SoftwareUniversityLearningSystem.Models.Students
{
    public class OnlineStudent: CurrentStudent
    {
        public OnlineStudent(string firstName, string lastName, uint age, uint studentNumber, double averageGrade, string currentCourse) : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
        {
        }
    }
}
