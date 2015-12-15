using System;

namespace FootballLeague.Models
{
    public class Player
    {
        private string firstName;
        private string lastName;
        private decimal salary;
        private DateTime dateOfBirth;
        private Team team;

        private const int MinimiumAllowedYear = 1980;

        public Player(string firstName, string lastName, decimal salary, DateTime dateOfBirth, Team team)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.DateOfBirth = dateOfBirth;
            this.team = team;
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentException("First name must be atleast 3 characters long");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentException("Last name must be alteast 3 characters long");
                }

                this.lastName = value;
            }
        }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The salary cannot be negative");
                }

                this.salary = value;
            }
        }

        public DateTime DateOfBirth
        {
            get { return this.dateOfBirth; }
            private set
            {
                if (value.Year < MinimiumAllowedYear)
                {
                    throw new ArgumentException("Date of birth cannot be lower than " + MinimiumAllowedYear);
                }

                this.dateOfBirth = value;
            }
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
