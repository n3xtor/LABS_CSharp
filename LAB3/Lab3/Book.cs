using System;
using System.Collections;
using System.Collections.Generic;

namespace BookStore
{
    class Book : IEnumerable<Book>, IEqualityComparer<Book>
    {
        public string Author { get; }
        public string Title { get; }
        public string Publisher { get; }
        public int Year { get; }

        public Book(string author, string title, string publisher, int year)
        {
            Author = author;
            Title = title;
            Publisher = publisher;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Author}. {Title}. {Publisher}, {Year}.";
        }

        public static bool operator ==(Book b1, Book b2)
        {
            if (Object.ReferenceEquals(b1, b2))
                return true;

            if (b1 is null || b2 is null)
                return false;

            return b1.Author == b2.Author && b1.Title == b2.Title &&
                b1.Publisher == b2.Publisher && b1.Year == b2.Year;
        }

        public static bool operator !=(Book b1, Book b2)
        {
            return !(b1 == b2);
        }

        public static bool operator >(Book b1, Book b2)
        {
            return b1.Volume() > b2.Volume();
        }

        public static bool operator <(Book b1, Book b2)
        {
            return b1.Volume() < b2.Volume();
        }

        public static Book operator +(Book b1, Book b2)
        {
            if (b1.Author != b2.Author)
                throw new ArgumentException("Cannot add books by different authors.");

            if (b1.Title != b2.Title)
                throw new ArgumentException("Cannot add books with different titles.");

            if (b1.Publisher != b2.Publisher)
                throw new ArgumentException("Cannot add books published by different publishers.");

            if (b1.Year != b2.Year)
                throw new ArgumentException("Cannot add books published in different years.");

            return new Book(b1.Author, b1.Title, b1.Publisher, b1.Year) { Pages = b1.Pages + b2.Pages };
        }

        public virtual int Pages { get; set; }

        public virtual int Volume()
        {
            return Pages / 32;
        }

        // Інтерфейс IEnumerable
        public IEnumerator<Book> GetEnumerator()
        {
            yield return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // Інтерфейс IEqualityComparer
        public bool Equals(Book x, Book y)
        {
            return x == y;
        }

        public int GetHashCode(Book obj)
        {
            return obj.GetHashCode();
        }
    }

    class Monograph : Book
    {
        public int Illustrations { get; }

        public Monograph(string author, string title, string publisher, int year, int pages, int illustrations) : base(author, title, publisher, year)
        {
            Pages = pages;
            Illustrations = illustrations;
        }

        public override string ToString()
        {
            return $"{base.ToString()} {Pages} pages, {Illustrations} illustrations.";
        }

        public override int Volume()
        {
            return base.Volume() + Illustrations;
        }
    }

    class MultiVolumeEdition : Book
    {
        public int Volumes { get; }
        public int PagesPerVolume { get; set; }

        public MultiVolumeEdition(string author, string title, string publisher, int year, int volumes, int pagesPerVolume) : base(author, title, publisher, year)
        {
            Volumes = volumes;
            PagesPerVolume = pagesPerVolume;
        }

        public override string ToString()
        {
            return $"{base.ToString()} {Volumes} volumes, {PagesPerVolume} pages per volume.";
        }

        public override int Pages
        {
            get { return Volumes * PagesPerVolume; }
            set { PagesPerVolume = value / Volumes; }
        }
    }
}
