using System;

namespace LibraryClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library("Pencho Slaveikov");
            Book book1 = new Book("The Misterious Run", "JJ Rowns", "Ciela", "2020", "1092340");
            Book book2 = new Book("The Misterious Hunt", "Joke Rowns", "Cimba", "1820", "1424240");
            Book book3 = new Book("The Misterious Jump", "KK Rowns", "Liela", "1920", "1095314");
            Book book4 = new Book("Killers", "KK Rowns", "Liela", "1920", "1095314");
            Book book5 = new Book("SuperAdventure", "KK Rowns", "Liela", "1920", "1095314");
            Book book6 = new Book("The Jump", "KK Rowns", "Liela", "1920", "1095314");
            library.AddBook(book1, book2, book3, book4, book5, book6);
            library.DeleteBook(1);
            library.PrintBookInformation(1);
            library.SearchByAuthor("KK Rownas");
            library.PrintAllBooks();
        }
    }
}
