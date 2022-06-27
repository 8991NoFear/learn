using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinq
{
    class Program
    {
        /*
         * LINQ (Language Integrated Query)
         * 
         * Types of LINQ
         * +, Linq to Objects (query objects)
         * +, Linq to Entities (query database)
         * +, Linq to XML (query xml)
         * +, Linq to Datasets (query ADO.NET)
         */
        static void Main(string[] args)
        {
            var books = new BookRepo().getBooks();

            // Syntax 1: LINQ Query Operators
            //var cheapBooks1 = from b in books
            //                  where b.Price < 10
            //                  orderby b.Price
            //                  select b.Title;

            // Syntax 2: LINQ Extension Methods
            //var cheapBooks2 = books
            //                    .Where(b => b.Price < 10)
            //                    .OrderBy(b => b.Price)
            //                    .Select(b => b.Title);

            // OTHER USEFUL LINQ OPERATIONS

            //var book = books.Single(b => b.Title == "Advanced C#"); // SingleOrDefault()

            //var book = books.First(b => b.Title == "Advanced C#"); // FirstOrDefault()

            //var book = books.Last(b => b.Title == "Advanced C#"); // LastOrDefault()

            //var book = books.Skip(1).Take(2);

            //var no = books.Count();

            //var maxPrice = books.Max(b => b.Price);

            //var minPrice = books.Min(b => b.Price);

            //var totalPrice = books.Sum(b => b.Price);

            //var averagePrice = books.Average(b => b.Price);
        }
    }

    class BookRepo
    {
        public List<Book> getBooks()
        {
            return new List<Book>()
            {
                new Book() { Title = "Beginning C#", Price = 19.9f},
                new Book() { Title = "Intermediate C#", Price = 9.9f},
                new Book() { Title = "Advanced C#", Price = 13.9f},
                new Book() { Title = "Beginning .NET", Price = 6.9f},
                new Book() { Title = "Intermediate .NET", Price = 15.9f},
                new Book() { Title = "Advanced .NET", Price = 3.9f},
            };
        }
    }

    class Book
    {
        public string Title { get; set; }
        public float Price { get; set; }
    }
}
