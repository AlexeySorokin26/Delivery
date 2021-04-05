using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery
{
    class Book : Product
    {
        private ushort numberOfPages;
        private string author;
        private ushort yearPublished;
        public Book(string name, float price, 
            ushort numberOfPages, string Author, ushort yearPublished) : base(name, price) 
        {
            this.numberOfPages = numberOfPages;
            this.author = Author;
            this.yearPublished = yearPublished;
        }

        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }
        public ushort NumberOfPages
        {
            get { return this.numberOfPages; }
            set { this.numberOfPages = value; }
        }
        public ushort YearPublished
        {
            get { return this.yearPublished; }
            set { this.yearPublished = value; }
        }

    }
}
