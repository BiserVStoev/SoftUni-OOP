using System.Collections.Generic;
namespace _03.CompanyHierarchy.Interfaces
{
    public interface IManager: IEmployee
    {
        IEnumerable<IEmployee> Employees { get; }

        void AddEmployee(IEmployee employee);
    }
}
