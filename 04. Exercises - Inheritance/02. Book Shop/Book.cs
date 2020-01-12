using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookShop
{
    public class Book
    {
        private string author;

        public string Author
        {
            get { return author; }
            set
            {
                // if (IsCharDigit(value.Split(' ',StringSplitOptions.RemoveEmptyEntries)[1][0]))
                if (value.Split().Length > 1 && Char.IsDigit(value.Split().Skip(1).First().First()))
                {
                    throw new ArgumentException("Author not valid!");
                }
                author = value;
            }
        }

        private string title;

        public string Title
        {
            get { return title; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                title = value;
            }
        }

        private decimal price;

        public virtual decimal Price
        {
            get { return price; }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                price = value;
            }
        }

        public Book(string author, string title, decimal price)
        {
            Author = author;
            Title = title;
            Price = price;
        }
        //public static bool IsCharDigit(char c)
        //{
        //    return ((c >= '0') && (c <= '9'));
        //}

        public override string ToString()
        {
            return $"Type: {this.GetType().Name}" + Environment.NewLine +
                $"Title: {Title}" + Environment.NewLine +
                $"Author: {Author}" + Environment.NewLine +
                $"Price: {Price:F2}";
        }
    }
}
