using System;
using _02.Customer.Enums;
using _02.Customer.Models;

namespace _02.Customer
{
    using Models;
    class ProgramMain
    {
        static void Main()
        {
            Customer customerA = new Customer("Ivan", "Ivanov", "Georgiev", 9506154721, "Dj", "+359878847625", "ivan@ivan.bg", CustomerType.Golden);

            Customer customerB = new Customer("Mihail", "Dimitrov", "Dimitrov", 8711115564, "Druzhba", "++359898755801", "misho@dimo.bg", CustomerType.Diamond);

            Console.WriteLine(customerA == customerB);
            Console.WriteLine(customerA != customerB);
            Console.WriteLine(customerA.Equals(customerB));

            Customer customerC = (Customer)customerB.Clone();

            customerC.AddPayment(new Payment("Manjda", 175));
            customerC.AddPayment(new Payment("Topka", 20));
            customerC.AddPayment(new Payment("Computer", 1502));

            Console.WriteLine(customerC);
            Console.WriteLine(customerB);
            Console.WriteLine(customerB.CompareTo(customerA));
        }
    }
}
