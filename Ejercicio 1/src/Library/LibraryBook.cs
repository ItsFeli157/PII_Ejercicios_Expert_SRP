using System;

namespace SRP
{
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
