using System;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy.Models
{
    public abstract class Employee: Person, IEmployee
    {
        private decimal salary;

        protected Employee(int id, string firstName, string lastName, decimal salary, DepartmentType department) : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
                
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be negative!");
                }

                this.salary = value; 
                
            }
        }

        public DepartmentType Department { get; set; }

        public override string ToString()
        {
            return base.ToString() + string.Format(" department: {0}, salary: {1}", this.Department, this.Salary);
        }
    }
}
