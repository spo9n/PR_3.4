using System;
using System.Collections.Generic;
using System.Text;

namespace PR_3._4_Surgai
{
    class Library
    {
        private List<Book> Books;

        public Library(List<Book> books)
        {
            this.Books = books;
        }

        public void SortBooksByName()
        {

            Books.Sort(delegate (Book currentBook, Book nextBook)
            {
                return currentBook.GetName().CompareTo(nextBook.GetName());
            });
        }

        public void SortBooksByAuthor()
        {
            Books.Sort(delegate (Book currentBook, Book nextBook)
            {
                return currentBook.GetAuthor().CompareTo(nextBook.GetAuthor());
            });
        }

        public void SortBooksByPublisher()
        {
            Books.Sort(delegate (Book currentBook, Book nextBook)
            {
                return currentBook.GetPublisher().CompareTo(nextBook.GetPublisher());
            });
        }

        public void PrintBooks()
        {
            foreach (Book book in Books)
            {
                Console.WriteLine(book.Print());
            }
        }
    }
}
