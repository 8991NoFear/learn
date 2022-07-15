using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    /*
     * What? Is a property but provide a way to access elements in class that represents as list of value
     * Why? For convinence: eliminate SetItem() and GetItem() method
     */
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie(DateTime.Now.AddDays(7));
            cookie["name"] = "Binhld8";
            Console.WriteLine(cookie["name"]);
        }
    }
}
