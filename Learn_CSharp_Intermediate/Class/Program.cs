using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    partial class Program
    {
        /*
         * C# use PascalCase for name of class, property, method
         * and camelCase for name of local variable, parameter
         * 
         * Why we use static member: To represent concept of singleton
         */
        static void Main(string[] args)
        {
            //var person = new Person();
            var person = Person.Parse("Do Le");
            person.Introduce("Le Binh");
        }
    }
}
