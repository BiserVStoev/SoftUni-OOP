using System;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy.Models
{
    public class Project: IProject
    {
        private string name;
        private string details;

        public Project(string name, DateTime startDate, string details, bool isOpen)
        {
            this.Name = name;
            this.StartDate = startDate;
            this.Details = details;
            this.IsOpen = isOpen;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value?.Trim().Length == 0)
                {
                    throw new ArgumentException("Name cannot be null or empty!");
                }

                this.name = value;
            }
        }

        public DateTime StartDate { get; set; }

        public string Details
        {
            get
            {
                return this.details;
                
            }

            set
            {
                if (value?.Trim().Length == 0)
                {
                    throw new ArgumentException("Details cannot be null or empty!");
                }

                this.details = value;
            }
        }

        public bool IsOpen { get; set; }
    }
}
