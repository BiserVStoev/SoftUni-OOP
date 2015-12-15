using System.Collections.Generic;

namespace _03.CompanyHierarchy.Interfaces
{
    public interface ISalesEmployee: IRegularEmployee
    {
        void AddSale(ISale sale);

        IEnumerable<ISale> Sales { get; }
    }
}
