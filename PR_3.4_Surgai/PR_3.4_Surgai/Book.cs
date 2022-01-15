using System;
using System.Collections.Generic;
using System.Text;

namespace PR_3._4_Surgai
{
    class Book
    {
        private string Name;
        private string Author;
        private string Publisher;

        public Book(string name, string author, string publisher)
        {
            this.Name = name;
            this.Author = author;
            this.Publisher = publisher;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetAuthor()
        {
            return Author;
        }

        public string GetPublisher()
        {
            return Publisher;
        }

        public string Print()
        {
            return "Name: " + Name + ";\n Author: " + Author + ";\n Publisher: " + Publisher + "\n";
        }
    }
}
