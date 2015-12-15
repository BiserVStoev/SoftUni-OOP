using System.Collections.Generic;

namespace _03.CompanyHierarchy.Interfaces
{
    public interface IDeveloper: IRegularEmployee
    {
        IEnumerable<IProject> Projects { get; }

        void AddProject(IProject project);

        void CloseProject(IProject project);
    }
}
