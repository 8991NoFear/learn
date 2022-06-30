using System.Collections.Generic;

namespace MyLinq
{
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
}
