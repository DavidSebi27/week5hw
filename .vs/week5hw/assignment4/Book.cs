﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    internal class Book
    {
        public string Title;
        public string Author;

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public void DisplayBookInfo()
        {
            Console.WriteLine($"Book information:\nTitle: {Title}\nAuthor: {Author}");
        }
    }
}
