namespace _01.HumanStudentAndWorker.Models
{
    using System;
    using System.Text.RegularExpressions;

    public class Student: Human
    {
        private const int MinFactNumLength = 5;
        private const int MaxFactNumLength = 10;

        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
                
            }

            private set
            {
                value = value ?? ""; //the c#6 way to check if null, and if true - make it an empty string

                if (!Regex.IsMatch(value, "^[A-Za-z0-9]{5,10}$"))
                {
                    throw new ArgumentException(string.Format("The faculty number must be between {0} and {1} long!", MinFactNumLength, MaxFactNumLength));
                }

                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} - Faculty number: {1}", base.ToString(), this.FacultyNumber);
        }
    }
}
