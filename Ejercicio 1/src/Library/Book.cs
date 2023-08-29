using System;

namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        //public string LibrarySector { get ; set; }
        //public string LibraryShelve { get ; set; }

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }
    }
        /*public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }*/

    public class Sector
    {
        public string Name {get; }

        public Sector(string name)
        {
            this.Name = name;
        }
    }

    public class Shelve
    {
        public string Number {get; }
        
        public Shelve(string number)
        {
            this.Number = number;
        }
    }

    public class LibraryBook
    {
        public Sector LibrarySector {get; set;}
        public Shelve LibraryShelve {get; set;}

        public void ShelveBook(Sector sector, Shelve shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }
    }
}