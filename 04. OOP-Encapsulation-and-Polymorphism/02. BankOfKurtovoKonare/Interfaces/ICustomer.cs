using _02.BankOfKurtovoKonare.Models;

namespace _02.BankOfKurtovoKonare.Interfaces
{
    public interface ICustomer
    {
        string Name { get; set; }

        CustomerType CustomerType { get; set; }
    }
}
