using System;
using System.Collections.Generic;
using System.Linq;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy.Models
{
    public class Developer: RegularEmployee, IDeveloper
    {
        private List<IProject> projects; 

        public Developer(int id, string firstName, string lastName, decimal salary, DepartmentType department) : base(id, firstName, lastName, salary, department)
        {
            this.projects = new List<IProject>();
        }

        public IEnumerable<IProject> Projects
        {
            get { return this.projects; }
        }

        public void AddProject(IProject project)
        {
            
            this.projects.Add(project);
        }

        public void CloseProject(IProject project)
        {
            bool found = this.projects.Any(currentProject => currentProject.Name == project.Name);

            if (!found)
            {
                throw new ArgumentException("Project not found!");
            }

            project.IsOpen = false;
        }
    }
}
