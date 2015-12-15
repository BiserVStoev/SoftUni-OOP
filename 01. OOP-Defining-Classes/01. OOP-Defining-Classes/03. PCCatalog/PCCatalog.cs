
using System;
using System.Collections.Generic;
using System.Linq;
using _03.PCCatalog;

class PCCatalog
{
    static void Main()
    {

        Component ssd = new Component("Toshiba", 220, "Model 2015");
        Component ram = new Component("ATI", 80, "1000 MHz");
        Component cpu = new Component("Intel", 300);

        Component ssd2 = new Component("Sony", 250, "Model 2016");
        Component ram2 = new Component("Lenovo", 75, "1100 MHz");
        Component cpu2 = new Component("Mama", 200);

        List<Computer> computers = new List<Computer>()
        {
            new Computer("Pravec", cpu2, ram, ssd),
            new Computer("Trica", cpu, ram, ssd2),
            new Computer("Acer", cpu, ram2, ssd),
        };

        computers.OrderBy(comp => comp.Price).ToList().ForEach(Console.WriteLine);
        
    }
}
