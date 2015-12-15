using System;

namespace _01.Persons
{
    public class Person
    {
        private string name;
        private int age;
        private string email;

        private const int MinAge = 1;
        private const int MaxAge = 100;
        
        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age)
            : this(name, age, null)
        {
        }

        private string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name cannot be empty");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("age", string.Format("The age must be in the range [{0}...{1}]", MinAge, MaxAge));
                }
               this.age = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || value.Contains("@"))
                {
                    email = value;
                }
                else
                {
                    throw new ArgumentException(@"The email must contain ""@"" or must be null ");
                }
                
            }
        }

        public override string ToString()
        {
            if (this.Email != null)
            {
                return string.Format("My name is {0}, I am {1} years old and my email address is {2}", this.Name,
                    this.Age, this.Email);
            }

            return string.Format("My name is {0} and I am {1} years old", this.Name, this.Age);
        }
    }
}
