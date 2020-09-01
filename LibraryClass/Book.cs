using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryClass
{
    class Book
    {
        private string title;
        private string author;
        private string production;
        private string releseYear;
        private string isbnNumber;

        public string Title
        {
            get
            {
                return this.title;
            }
        }
        public string Author
        {
            get
            {
                return this.author;
            }
        }
        public string Production
        {
            get
            {
                return this.production;
            }
        }
        public string ReleseYear
        {
            get
            {
                return this.releseYear;
            }
        }
        public string ISBN
        {
            get
            {
                return this.isbnNumber;
            }
        }

        public Book(string title, string author, string production, string releseYear, string isbnNumber)
        {
            this.title = title;
            this.author = author;
            this.production = production;
            this.releseYear = releseYear;
            this.isbnNumber = isbnNumber;
        }

        public Book(string author)
        {
            this.author = author;
        }
    }
}
