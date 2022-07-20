using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Where
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };

            var collection = list
                                .Where((num, idx) => num * idx % 2 == 0)
                                .Select((num, idx) => new { Number = num, Index = idx });

            foreach (var item in collection)
            {
                Console.WriteLine(item.Number + " - " + item.Index);
            }
        }
    }
}
