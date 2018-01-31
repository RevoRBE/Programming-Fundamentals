using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Library_Q
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
    }
    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            Library library = new Library();
            library.Books = new List<Book>();

            ImportBooks(library, num);

            var sortedBooks = library.Books
               .OrderByDescending(b => b.Price)
               .ThenBy(b => b.Author)
               .GroupBy(b => b.Author);

            foreach (IGrouping<string, Book> item in sortedBooks)
                Console.WriteLine($"{item.Key} -> {item.Sum(b => b.Price):f2}");
        }

        static void ImportBooks(Library library, int num)
        {
            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                library.Books.Add(new Book()
                {
                    Title = input[0],
                    Author = input[1],
                    Publisher = input[2],
                    ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBN = input[4],
                    Price = decimal.Parse(input[5])
                });
            }
        }
    }
}
