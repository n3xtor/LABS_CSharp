using System;

namespace BookStore
{
    interface IPages
    {
        int Pages { get; set; }
        int Volume();
    }

    interface IBookOperations
    {
        Book AddBooks(Book b);
        bool CheckEquality(Book b1, Book b2);
        bool CompareBooks(Book b1, Book b2);
        string DisplayBookDetails(Book b);
    }

    class Book : IPages, IBookOperations
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

        public Book AddBooks(Book b)
        {
            if (Author != b.Author)
                throw new ArgumentException("Cannot add books by different authors.");

            if (Title != b.Title)
                throw new ArgumentException("Cannot add books with different titles.");

            if (Publisher != b.Publisher)
                throw new ArgumentException("Cannot add books published by different publishers.");

            if (Year != b.Year)
                throw new ArgumentException("Cannot add books published in different years.");

            return new Book(Author, Title, Publisher, Year) { Pages = Pages + b.Pages };
        }

        public bool CheckEquality(Book b1, Book b2)
        {
            return b1 == b2;
        }

        public bool CompareBooks(Book b1, Book b2)
        {
            return b1 > b2;
        }

        public string DisplayBookDetails(Book b)
        {
            return b.ToString();
        }

        public virtual int Pages { get; set; }

        public virtual int Volume()
        {
            return Pages / 32;
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