<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAgain.Models
{
    class Library<T>
    {
        private T[]? _booklist = new T[0];

        public T this[int index]
        {
            get { return _booklist[index]; }
            set { _booklist[index] = value; }
        }


        public Library(int length)
        {
            Array.Resize(ref _booklist, length);
        }

       
        //public List<Book> FindAllBooksByName(string name)
        //{
        //    Book book = Book.FindByName(name);
        //}

        public void Add(T value)
        {
            Array.Resize(ref _booklist, _booklist.Length + 1);
            _booklist[^1] = value;
        }

        public void AddRange(T[] collection)
        {
            foreach (T item in collection)
            {
                Array.Resize(ref _booklist, _booklist.Length + 1);
                _booklist[^1] = item;
            }
        }
        
       
        public void BinarySearch(T item)
        {
            Array.BinarySearch(_booklist, item);
        }
        public int Capacity()
        {
            return _booklist.Length;
        }
      


        public T[] FindAll()
        {       
           return new T[_booklist.Length];
        }
       
      
      
       
        public void Remove(T item)
        {
            _booklist[Array.IndexOf(_booklist, item)] = default(T);
        }
        public void RemoveAll(int down, int up)
        {
            Array.Clear(_booklist, down, up);
        }
        public void RemoveAt(int index)
        {
            _booklist[index] = default(T);
        }
       

    }
=======
<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAgain.Models
{
    class Library<T>
    {
        private T[]? _booklist = new T[0];

        public T this[int index]
        {
            get { return _booklist[index]; }
            set { _booklist[index] = value; }
        }


        public Library(int length)
        {
            Array.Resize(ref _booklist, length);
        }

       
        //public List<Book> FindAllBooksByName(string name)
        //{
        //    Book book = Book.FindByName(name);
        //}

        public void Add(T value)
        {
            Array.Resize(ref _booklist, _booklist.Length + 1);
            _booklist[^1] = value;
        }

        public void AddRange(T[] collection)
        {
            foreach (T item in collection)
            {
                Array.Resize(ref _booklist, _booklist.Length + 1);
                _booklist[^1] = item;
            }
        }
        
       
        public void BinarySearch(T item)
        {
            Array.BinarySearch(_booklist, item);
        }
        public int Capacity()
        {
            return _booklist.Length;
        }
      


        public T[] FindAll()
        {       
           return new T[_booklist.Length];
        }
       
      
      
       
        public void Remove(T item)
        {
            _booklist[Array.IndexOf(_booklist, item)] = default(T);
        }
        public void RemoveAll(int down, int up)
        {
            Array.Clear(_booklist, down, up);
        }
        public void RemoveAt(int index)
        {
            _booklist[index] = default(T);
        }
       

    }
=======
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAgain.Models
{
    class Library<T>
    {
        private T[]? _booklist = new T[0];

        public T this[int index]
        {
            get { return _booklist[index]; }
            set { _booklist[index] = value; }
        }


        public Library(int length)
        {
            Array.Resize(ref _booklist, length);
        }

       
        //public List<Book> FindAllBooksByName(string name)
        //{
        //    Book book = Book.FindByName(name);
        //}

        public void Add(T value)
        {
            Array.Resize(ref _booklist, _booklist.Length + 1);
            _booklist[^1] = value;
        }

        public void AddRange(T[] collection)
        {
            foreach (T item in collection)
            {
                Array.Resize(ref _booklist, _booklist.Length + 1);
                _booklist[^1] = item;
            }
        }
        
       
        public void BinarySearch(T item)
        {
            Array.BinarySearch(_booklist, item);
        }
        public int Capacity()
        {
            return _booklist.Length;
        }
      


        public T[] FindAll()
        {       
           return new T[_booklist.Length];
        }
       
      
      
       
        public void Remove(T item)
        {
            _booklist[Array.IndexOf(_booklist, item)] = default(T);
        }
        public void RemoveAll(int down, int up)
        {
            Array.Clear(_booklist, down, up);
        }
        public void RemoveAt(int index)
        {
            _booklist[index] = default(T);
        }
       

    }
>>>>>>> d938e3c (homework)
>>>>>>> 537eb63 (homework)
}