using System.Collections.Generic;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy.Models
{
    public class SalesEmployee: RegularEmployee, ISalesEmployee
    {
        private List<ISale> sales; 

        public SalesEmployee(int id, string firstName, string lastName, decimal salary, DepartmentType department) : base(id, firstName, lastName, salary, department)
        {
            this.sales = new List<ISale>();
        }

        public void AddSale(ISale sale)
        {
            this.sales.Add(sale);
        }

        public IEnumerable<ISale> Sales
        {
            get { return this.sales; }
        }
    }
}
