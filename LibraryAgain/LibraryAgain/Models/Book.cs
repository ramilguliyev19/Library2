using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAgain.Models
{
    public class Book
    {
        public string AuthorName { get; set; }
        public string tName { get; set; }
        public string Title { get; set; }
        public int PageCount { get; set; }
    }

    List<Book> lstBooks = new List<Book>();
    lstBooks.Add(new Book()
    {
        AuthorLastName = "What",
                AuthorFirstName = "Ever",
                Title = Whatever
                Year = 2012;
    }
}

