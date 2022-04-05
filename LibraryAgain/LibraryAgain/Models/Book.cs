<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAgain.Models
{
    public class Book<T>
    {
        public string AuthorName { get; set; }
        public string Name { get; set; }
        public int PageCount { get; set; }
        public int Id { get; private set; }
        public string Code { get; private set; }
        
        
       
        
        private Book()


        {
           
            Code = Name[0].ToString().ToUpper() + Id;
        }

        public Book(string name, string authorName, int pageCount) : this()
        {
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
        }
    }
}

=======
<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAgain.Models
{
    public class Book<T>
    {
        public string AuthorName { get; set; }
        public string Name { get; set; }
        public int PageCount { get; set; }
        public int Id { get; private set; }
        public string Code { get; private set; }
        
        
       
        
        private Book()


        {
           
            Code = Name[0].ToString().ToUpper() + Id;
        }

        public Book(string name, string authorName, int pageCount) : this()
        {
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
        }
    }
}

=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAgain.Models
{
    public class Book<T>
    {
        public string AuthorName { get; set; }
        public string Name { get; set; }
        public int PageCount { get; set; }
        public int Id { get; private set; }
        public string Code { get; private set; }
        
        
       
        
        private Book()


        {
           
            Code = Name[0].ToString().ToUpper() + Id;
        }

        public Book(string name, string authorName, int pageCount) : this()
        {
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
        }
    }
}

>>>>>>> d938e3c (homework)
>>>>>>> 537eb63 (homework)
