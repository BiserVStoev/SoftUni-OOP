using System;

namespace _04.SoftwareUniversityLearningSystem.Models
{
    public abstract class Person
    {
        private string firstName;
        private string lastName;

        protected Person(string firstName, string lastName, uint age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            Age = age;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
                
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("First name cannot be null or empty!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;

            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Last name cannot be null or empty!");
                }

                this.lastName = value;
            }
        }

        public uint Age { get; set; }

        public override string ToString()
        {
            return string.Format("Person type - {0}, first name - {1}, last name - {2}, age - {3}", this.GetType().Name, this.FirstName, this.LastName, this.Age);
        }
    }
}
