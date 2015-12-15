using System;
using System.Collections.Generic;
using _03.CompanyHierarchy.Models;

namespace _03.CompanyHierarchy
{
    class ProgramMain
    {
        static void Main()
        {
            List<Person> people = new List<Person>
            {
                new Developer(69, "Maëly", "Howell", 998.88m, DepartmentType.Production),
                new SalesEmployee(159, "Matthew", "Hart", 898.88m, DepartmentType.Sales),
                new SalesEmployee(85, "Alice", "Nguyen", 798.88m, DepartmentType.Sales),
                new Manager(1, "Beverly", "Jenkins", 698.88m, DepartmentType.Accounting),
                new Manager(333, "Steven", "Rose", 1998.88m, DepartmentType.Marketing),
                new Developer(5698, "Norma", "Lynch", 2098.88m, DepartmentType.Production),
                new SalesEmployee(197, "Heather", "Simpson", 80.88m, DepartmentType.Sales),
                new SalesEmployee(179, "Samuel", "Price", 80.88m, DepartmentType.Sales),
                new Manager(6, "Kathy", "Lawson", 9908.88m, DepartmentType.Marketing),
                new Developer(9, "Janet", "Willis", 198.88m, DepartmentType.Production),
                new Manager(123, "Kelly", "Gutierrez", 398.88m, DepartmentType.Accounting),
            };

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
