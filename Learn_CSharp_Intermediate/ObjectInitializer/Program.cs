using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializer
{
    /*
     * What? Object initializer = default contructor + init fields
     * Why? no need to write lots of constructor
     */
    class Program
    {
        static void Main(string[] args)
        {
            // code below is wrong because Customer class doesn't have default constructor
            //var customer = new Customer() { id = 1, name = "Binhld8" };
        }
    }
}
