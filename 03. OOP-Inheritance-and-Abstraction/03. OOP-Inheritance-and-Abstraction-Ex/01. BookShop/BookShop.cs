using System;
using _01.BookShop;

class BookShop
{
    static void Main()
    {
        Book book = new Book("Pod igoto", "Ivan Vazov", 15.90m);

        Console.WriteLine(book);

        GoldenEditionBook goldenBook = new GoldenEditionBook("Tutun", "Dimitar Dimov", 22.90m);

        Console.WriteLine(goldenBook);
    }
}