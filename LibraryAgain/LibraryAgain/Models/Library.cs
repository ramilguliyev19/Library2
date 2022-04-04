using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryAgain.Models;

namespace LibraryAgain.Models
{
    public class Library

    {
        public List<Book> Books { get; set; }

        public void AddBook(Book book)
        {
            if (book == null) throw new ArgumentNullException();
                    Books.Add(book);
        }
        public List<Book> FindAllBooksByName(string name) == name;
        if (Book == null) throw new Exception(string name);
  return book; 
}
    public void RemoveAllBooksbyName(string string name)
    {
        Book book = Books.Find(x => x.Name == name);
        if (name == null) throw new Exception()

        Console.WriteLine(Books.Remove(book));
}
}

