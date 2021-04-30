using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class BookCatalog
    {
        public static readonly List<string> _bookCatalog = new List<string>();

        public static void Books()
        {
            Book book = new Book("", "");
            _bookCatalog.Add(book);
        }
    }
}
