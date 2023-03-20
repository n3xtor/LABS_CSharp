using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BookStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[]
            {
                new Book("Marijn Haverbeke", "JavaScript", "Riga Press", 2011) { Pages = 480 },
                new Monograph("Hryhoriy Starikov", "Diary of Alexander Konysky", "Unknown Press", 2013, 1550, 50),
                new MultiVolumeEdition("Uzbek", "Encyclopedia of Uzbekistan", "Uzbekistan Science", 2005, 12, 1440)
            };

            Console.ReadKey();
        }
    }
}
