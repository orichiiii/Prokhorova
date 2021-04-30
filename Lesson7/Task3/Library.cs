using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Linq;

namespace Task3
{
    public class Library : Book
    {
        public static List<Book> BooksCatalog = new List<Book>();

        public static void DefaultBooks()
        {
            BooksCatalog.Add(new Book("The Lord of the Rings", "J.R.R. Tolkien"));
            BooksCatalog.Add(new Book("The Great Gatsby", "F. Scott Fitzgerald"));
            BooksCatalog.Add(new Book("The Book Thief", "Markus Zusak"));
            BooksCatalog.Add(new Book("The Hobbit", "J.R.R. Tolkien"));
            BooksCatalog.Add(new Book("Jane Eyre", "Charlotte Bronte"));
        }

        public static void ChooseAction()
        {
            Write("\n Please choose the action: (1)Add book, (2)Delete book, " +
            "(3)Show all books,  (4)Show books frome one author, (5)Find a book by words, (6)Take a book to read, (7)View how many days the user had the book: ");
            var userAction = ReadLine();

            switch (userAction)
            {
                case "1": AddBook(); break;
                case "2": DeleteBook(); break;
                case "3": ShowAllBooks(); break;
                case "4": ShowBooksFromOneAuthor(); break;
                case "5": FindBookByWords(); break;
                case "6": TakeBook(); break;
                case "7": DaysOfUse(); break;
                default: throw new ArgumentException($"Invalid operation {userAction}.");
            }
        }

        private static void DaysOfUse()
        {
            WriteLine("Please enter the title of the book: ");
            var titleOfBook = ReadLine();

            var selectedBook = BooksCatalog.Find(x => x.Name == titleOfBook);
            if (selectedBook == null)
                WriteLine("This book does not exist in our library.");
            else
                WriteLine(selectedBook.DaysofUse);
        }

        private static void TakeBook()
        {
            if (BooksCatalog.Count == 0)
                WriteLine("Book catalog is empty.");
            else
            {
                WriteLine("Please enter the title of the book you want to take: ");
                var titleOfBook = ReadLine();

                var selectedBook = BooksCatalog.Find(x => x.Name == titleOfBook);
                PersonsLog.PersonData(selectedBook);
            }
        }

        private static void FindBookByWords()
        {
            if (BooksCatalog.Count == 0)
                WriteLine("Book catalog is empty.");
            else
            {
                WriteLine("Please enter the word/s in the title of the book you want to find: ");
                var wordInTheTitle = ReadLine();

                var selectedBooks = BooksCatalog.Where(b => b.Name.Contains(wordInTheTitle));
                if (selectedBooks == null)
                    WriteLine("no such book exists in our library.");
                else
                    foreach (Book book in selectedBooks)
                        WriteLine(book);
            }
        }

        private static void ShowBooksFromOneAuthor()
        {
            if (BooksCatalog.Count == 0)
                WriteLine("Book catalog is empty.");
            else
            {
                Write("Please enter the name of the author: ");
                var authorOfBook = ReadLine();

                var selectedBooks = BooksCatalog.Where(book => book.Author == authorOfBook);
                if (selectedBooks == null)
                    WriteLine("no such book exists in our library.");
                else
                    foreach (Book book in selectedBooks)
                        WriteLine($"{book.Name}, {book.Author}");
            }
        }

        private static void ShowAllBooks()
        {
            if (BooksCatalog.Count == 0)
                WriteLine("Book catalog is empty.");
            else
            {
                foreach (var book in BooksCatalog)
                    WriteLine($"{book.Name}, {book.Author}");
            }
        }

        private static void DeleteBook()
        {
            if (BooksCatalog.Count == 0)
                WriteLine("Book catalog is empty.");
            else
            {
                Write("Please enter title of the book you want to delete: ");
                var nameOfBook = ReadLine();

                Write("Please enter the name of the author of the book you want to delete: ");
                var authorOfBook = ReadLine();

                var selectedBook = BooksCatalog.Find(x => x.Name == nameOfBook);

                if (BooksCatalog.Remove(selectedBook))
                    WriteLine($"{selectedBook} has been successfully removed from the book catalog");
                else
                    WriteLine($"{selectedBook} does not exist in the catalog.");
            }
        }

        private static void AddBook()
        {
            Write("Please enter title of the book you want to add: ");
            var nameOfBook = ReadLine();

            Write("Please enter the name of the author of the book you want to add: ");
            var authorOfBook = ReadLine();

            Book userBook = new Book(nameOfBook, authorOfBook);

            BooksCatalog.Add(userBook);
        }
    }
}
