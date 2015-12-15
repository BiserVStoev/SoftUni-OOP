
using System;
using _02.LaptopShop;

class LaptopShop
{
    public static void Main()
    {
        Laptop laptop = new Laptop("Lenovo Yoga 2 Pro", 2259);

        Laptop laptop2 = new Laptop("Lenovo Yoga 2 Pro", 2259, "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", "8 GB", "Intel HD Graphics 4400", "128GB SSD", @"13.3"" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display", new Battery("Li-Ion", 4, 2550), 4.5);

        Console.WriteLine(laptop);

        Console.WriteLine(laptop2);
    }
}
