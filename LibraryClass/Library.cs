using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryClass
{
    class Library
    {
        // Fields
        private string name;
        private List<Book> books = new List<Book>();

        // Properties
        public string Name
        {
            get
            {
                return this.name;
            }
        }

        // Constructor
        public Library(string name)
        {
            this.name = name;
        }

        // Methods
        public void AddBook(params Book[] bookArr)
        {
            foreach(Book book in bookArr)
            {
                books.Add(book);
            }
        }
        
        public void SearchByAuthor(string authorName)
        {
            List<Book> booksByAuthor = new List<Book>();
            foreach(Book book in books)
            {
                if (book.Author == authorName)
                {
                    booksByAuthor.Add(book);
                }
            }
            if(booksByAuthor.Count == 0)
            {
                Console.WriteLine("=--------------------------=");
                Console.WriteLine($"Author: {authorName}");
                Console.WriteLine("____________________________\nBooks:\nNot Found!");
                Console.WriteLine("=--------------------------=\n");
                return;
            }
            Console.WriteLine($"Author: {authorName}");
            Console.WriteLine("____________________________\nBooks:\n ");
            foreach(Book bookByAuthor in booksByAuthor)
            {
                Console.WriteLine("- " + bookByAuthor.Title);
            }
            Console.WriteLine("=--------------------------=\n");
            
        }
        
        // The Number of the books can be getted from PringAllBooks
        public void DeleteBook(int number)
        {
            books[number - 1] = null;
            for (int i = number - 1; i < books.Count - 1; i++)
            {
                books[i] = books[i + 1];
            }
            books.Remove(books[books.Count - 1]);
        }

        public void PrintBookInformation(int number)
        {
            Book book = books[number - 1];
            Console.WriteLine("============================");
            Console.WriteLine($"Title:{book.Title}, \nAuthor:{book.Author}, \nRelese Year:{book.ReleseYear}, \nProduction:{book.Production}, \nISBN:{book.ISBN}");
            Console.WriteLine("============================\n");
        }

        public void PrintAllBooks()
        {
            int number = 1;
            Console.WriteLine("====================================================================");
            foreach (Book book in books)
            {
                Console.WriteLine($"No{number}: Title \"{book.Title}\" Author - {book.Author} || ISBN {book.ISBN}");
                number++;
                if(books.Count + 1 != number)
                {
                    Console.WriteLine("--------------------------------------------------------------------");
                }
            }
            Console.WriteLine("====================================================================\n");
        }
    }
}
