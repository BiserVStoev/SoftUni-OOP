using System;
using _01.Persons;

class PersonData
{
    static void Main()
    {
        Person pesho = new Person("Pesho", 18, "myEmail@abv.net");
        Person ivan = new Person("Ivan", 14);

        Console.WriteLine(pesho);
        Console.WriteLine(ivan);

        try
        {
            Person unnamed = new Person("", 20);
        }
        catch (ArgumentException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }

        try
        {
            Person negativeAge = new Person("Maria", -1);
        }
        catch (ArgumentException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }
    }
}
