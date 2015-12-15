using System;
using System.Runtime.Remoting.Channels;

namespace _01.BookShop
{
    class Book
    {
        private string title;
        private string author;
        private decimal price;

        public Book(string title, string author, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public string Title
        {
            get
            {
                return this.title;
            }

            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Title cannot be null");
                }

                this.title = value;
            }
        }

        public string Author
        {
            get
            {
                return this.author;
            }

            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Author cannot be null");
                }

                this.author = value;
            }
        }

        public virtual decimal Price
        {
            get
            {
                return this.price;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            return string.Format("-Type: {0}{4}-Title: {1}{4}-Author: {2}{4}-Price: {3:F2}", this.GetType().Name, this.Title, this.Author,
                this.Price, Environment.NewLine);
        }
    }
}
