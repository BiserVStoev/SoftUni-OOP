using System;

namespace _01.BookShop
{
    class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string title, string author, decimal price) : base(title, author, price)
        {
        }

        public override decimal Price
        {
            get
            {
                return base.Price * 1.3m;
            }
        }

        public override string ToString()
        {
            return string.Format("-Type: {0}{4}-Title: {1}{4}-Author: {2}{4}-Price: {3:F2}", this.GetType().Name, this.Title, this.Author, this.Price, Environment.NewLine);
        }
    }
}
