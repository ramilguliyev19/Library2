using System;
using System.Collections.Generic;
using LibraryAgain.Models;

namespace LibraryAgain
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<Book> booklist = new List<Book>();

            Book book1 = new Book("Harry", "Potter");
            Book book2 = new Book("Sophie's", "World");
            booklist.Add(book1);
            booklist.Add(book2);
            booklist.FindAllBooksByName("Harry""Potter")
        }
    }
}
