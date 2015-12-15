using System;
using System.Collections.Generic;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy.Models
{
    public class Manager: Employee, IManager
    {
        private readonly List<IEmployee> employees; 

        public Manager(int id, string firstName, string lastName, decimal salary, DepartmentType department) : base(id, firstName, lastName, salary, department)
        {
            this.employees = new List<IEmployee>();
        }

        public IEnumerable<IEmployee> Employees
        {
            get { return this.employees; }
        }

        public void AddEmployee(IEmployee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException("Employee cannot be null!");
            }

            if (employee.Department != this.Department)
            {
                throw new ArgumentException("Department of employee and manager must be the same!");
            }

            this.employees.Add(employee);
        }
    }
}
