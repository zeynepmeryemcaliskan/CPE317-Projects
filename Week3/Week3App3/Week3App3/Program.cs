using System;

namespace Week3App3
{
    

    class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book()
        {
            title = "Untitled";
            author = "Unknown";
            pages = 0;
        }

        public Book(string title, string author, int pages)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
        }

        public void Describe()
        {
            Console.WriteLine($"{title} by {author}, {pages} pages");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book a = new Book();
            Book b = new Book("Dil Belası", "Gazali", 500);

            a.Describe();
            b.Describe();
        }
    }

        
    
}
