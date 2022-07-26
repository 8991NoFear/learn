using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializer
{
    /*
     * What? Object initializer = contructor + init fields
     * Why? no need to write lots of constructor
     */
    class Program
    {
        static void Main(string[] args)
        {
            //var customer = new Customer(10) { Name = "BinhDZ" };
            //Console.WriteLine(customer.Id);

            // code below is wrong because Customer class doesn't have default constructor
            //var customer = new Customer() { Id = 1, Name = "Binhld8" };
        }
    }
}
