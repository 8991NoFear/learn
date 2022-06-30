using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic variable = "Le Dinh Binh"; // type at compile time is dynamic but at runtime is string
            //variable++; // runtime exception
            variable = 23; // now it is int

            string x = "The Sun";
            dynamic y = x;
            long z = y; // runtime exception
        }
    }
}
