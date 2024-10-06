using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment8
{
    internal class Library
    {
        public Book[] books;
        public int count;

        public Library(int capacity)
        {
            books = new Book[capacity];
            count = 0;
        }

        public void AddBook(Book book)
        {
            books[count] = book;
            count++;
        }

        public void DisplayBooks()
        {
            if (count == 0)
            {
                Console.WriteLine("No books in the library.");
            }

            Console.WriteLine("\nBooks in library: ");
            for (int i = 0; i < count; i++)
            {
                books[i].DisplayBookInfo();
            }
        }
    }
}
