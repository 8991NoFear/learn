using System;
using System.Collections.Generic;

namespace Generics
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

    class GenericDictionary<TKey, TValue>
    {
        private Dictionary<TKey, TValue> dict;

        public GenericDictionary()
        {
            dict = new Dictionary<TKey, TValue>();
        }

        public bool Add(TKey key, TValue value)
        {
            dict.Add(key, value);
            return true;
        }

        public TValue this[TKey key]
        {
            get
            {
                return dict[key];
            }
        }
    }

    class Book
    {
        public string Title { get; set; }
    }
}
