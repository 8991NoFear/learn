using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    /*
     * What? class member that ecapsulate a getter/setter for accessing a field
     * Why? to write less code 
     * Class should be in valid state
     */
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1998, 11, 23));
            //person.Birthdate = new DateTime(1998, 11, 23); // setter is private
            Console.WriteLine(person.Age);
        }
    }
}
