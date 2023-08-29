using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            
            Sector sectorA = new Sector("A");
            Shelve shelve7 = new Shelve("7");
            Sector sectorB = new Sector("B");
            Shelve shelve3 = new Shelve("3");
            
            LibraryBook libraryBook1 = new LibraryBook();
            LibraryBook libraryBook2 = new LibraryBook();

            libraryBook1.ShelveBook(sectorA, shelve7);
            libraryBook2.ShelveBook(sectorB, shelve3);

            Console.WriteLine($"Book 1 - Title: {book1.Title}, Author: {book1.Author}");
            Console.WriteLine($"Library Location - Sector: {libraryBook1.LibrarySector.Name}, Shelve: {libraryBook1.LibraryShelve.Number}");
            Console.WriteLine($"Book 2 - Title: {book2.Title}, Author: {book2.Author}");
            Console.WriteLine($"Library Location - Sector: {libraryBook2.LibrarySector.Name}, Shelve: {libraryBook2.LibraryShelve.Number}");

            //book1.ShelveBook("A","7");
            //book2.ShelveBook("B","3");
        }
    }
}