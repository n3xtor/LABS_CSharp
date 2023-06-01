namespace LibraryManagement
{
    public struct Book
    {
        public string Title { get; }
        public string Author { get; }
        public string Genre { get; }
        public int Year { get; }
        public int PageCount { get; }
        public string Language { get; }


        public Book(string title, string author, string genre, int year, int pageCount, string language)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Year = year;
            PageCount = pageCount;
            Language = language;
        }
    }
}
