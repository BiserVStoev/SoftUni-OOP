namespace _03.CompanyHierarchy.Interfaces
{
    public interface ICustomer: IPerson
    {
        decimal Balance { get; set; }
    }
}
