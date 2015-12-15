using System;

namespace _03.CompanyHierarchy.Interfaces
{
    public interface ISale
    {
        string SaleName { get; set; }

        decimal Price { get; set; }

        DateTime SoldOn { get; set; }
    }
}
