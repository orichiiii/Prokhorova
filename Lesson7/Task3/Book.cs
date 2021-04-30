using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    public class Book
    {
        public string Name { get;  }
        public string Author { get; }
        public int DaysofUse { get; set; }

        public Book (string name, string author)
        {
            Name = name;
            Author = author;
        }
        public Book()
        {

        }
    }
}
