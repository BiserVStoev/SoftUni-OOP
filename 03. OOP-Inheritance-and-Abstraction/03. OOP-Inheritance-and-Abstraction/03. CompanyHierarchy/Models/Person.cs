using System;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy.Models
{
    public abstract class Person : IPerson
    {
        private string firstName;
        private string lastName;
        private int id;

        protected Person(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int Id
        {
            get
            {
                return this.id;
                
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Id cannot be negative!");
                }

                this.id = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
                
            }

            set
            {
                if (value?.Trim().Length == 0)
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

                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name cannot be null or empty!");
                }

                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Id: {0}, Type: {1}, first name: {2}, last name: {3}", this.Id, this.GetType().Name, this.FirstName, this.LastName);
        }
    }
}
