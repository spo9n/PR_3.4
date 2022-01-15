using System;
using System.Collections.Generic;

namespace PR_3._4_Surgai
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> Books = new List<Book>();

            Books.Add(new Book("Void", "Clyde Bertram", "ACM"));
            Books.Add(new Book("Pointer", "William McDaniel", "OWS"));
            Books.Add(new Book("Vision", "Peter Chandler", "BKSJ"));
            Books.Add(new Book("Owl", "George Bennett", "BKSJ"));
            Books.Add(new Book("Eye", "Robert Wilkinson", "ASK"));


            Library library = new Library(Books);

            library.SortBooksByPublisher();
            library.PrintBooks();
        }
    }
}