using System;

namespace MyGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDict = new GenericDictionary<string, Book>();
            myDict.Add("isbn01", new Book() { Title = "Harry Potter" });
            myDict.Add("isbn02", new Book() { Title = "The old man and the sea" });
            myDict.Add("isbn03", new Book() { Title = "Alice in wonderland" });

            var myBook = myDict["isbn03"];
            Console.WriteLine(myBook.Title);
        }
    }
}
