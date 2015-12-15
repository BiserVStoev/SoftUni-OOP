using System;

namespace _03.CompanyHierarchy.Interfaces
{
    public interface IProject
    {
        string Name { set; get; }
        DateTime StartDate { set; get; }
        string Details { set; get; }
        bool IsOpen { set; get; }
    }
}
