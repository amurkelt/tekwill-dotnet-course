namespace Homework2
{
    internal class Book
    {
        private string title;
        private string author;
        private DateOnly year;
        private int pages;

        public Book()
        {
        }

        public Book(string title, string author, DateOnly year, int pages)
        {
            this.title = title;
            this.author = author;
            this.year = year;
            this.pages = pages;
        }

        public string Title
        {
            get { return title; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    title = value;
                }
            }
        }

        public string Author
        {
            get { return author; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    author = value;
                }
            }
        }

        public DateOnly Year
        {
            get { return year; }
            set { year = value; }
        }

        public int Pages
        {
            get { return pages; }
            set
            {
                if (value >= 0)
                {
                    pages = value;
                }
            }
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Titlu: {title}");
            Console.WriteLine($"Autorul: {author}");
            Console.WriteLine($"An de publicare: {year}");
            Console.WriteLine($"Numarul de pagini: {pages}");
        }
    }
}