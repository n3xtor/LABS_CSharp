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
                new Book("Stewen Prata", "C++", "Addison-Wesley", 2011) { Pages = 480 },
                new Book("Stewen Prata", "Unix", "Addison-Wesley", 2008) { Pages = 520 },
                new Book("Al Sweigart", "Python", "Addison-Wesley", 2017) { Pages = 376 },
                new Monograph("Hryhorii Starykiv", "Thoughts and notes", "Unknown Press", 2013, 1550, 15),
                new MultiVolumeEdition("Uzbek", "Encyclopedia of Uzbekistan", "Uzbekistan Science", 2005, 12, 1440)
            };

            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine();

 
            Console.WriteLine("Enter information about a new book:");
            Console.Write("Author: ");
            string author = Console.ReadLine();
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.Write("Publisher: ");
            string publisher = Console.ReadLine();
            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Pages: ");
            int pages = int.Parse(Console.ReadLine());
            Console.Write("Illustrations (0 if none): ");
            int illustrations = int.Parse(Console.ReadLine());

            Book newBook;
            if (illustrations == 0)
            {
                newBook = new Book(author, title, publisher, year) { Pages = pages };
            }
            else
            {
                newBook = new Monograph(author, title, publisher, year, pages, illustrations);
            }

            Array.Resize(ref books, books.Length + 1);
            books[books.Length - 1] = newBook;

            Console.WriteLine("\nAll books:");
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine();

            // найбільша книжка
            Book largest = books[0];
            foreach (Book book in books)
            {
                if (book > largest)
                {
                    largest = book;
                }
            }

            Console.WriteLine($"The largest book is: {largest} ({largest.Volume()} pages).");

            if (largest is MultiVolumeEdition)
            {
                Console.Write
                    ("It is a multivolume edition.\n\n");
            }

            // створення колекції книг певного автора і вивід
            Console.WriteLine("Search books by specific author:");
            Console.Write("Enter the author's name: ");
            string searchAuthor = Console.ReadLine();

            Book[] authorBooks = Array.FindAll(books, book => book.Author == searchAuthor);

            Console.WriteLine($"Books by {searchAuthor}:");
            foreach (Book book in authorBooks)
            {
                Console.WriteLine(book);
            }


            Console.Write("\nPress any button to continue...");
            Console.ReadKey();
        }
    }
}
