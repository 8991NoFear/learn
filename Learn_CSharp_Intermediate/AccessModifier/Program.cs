using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    /*
     * What? public, private, protected, internal, protected internal
     * Why? Encapsulation (or information hiding)
     * How? private for field and public for getter/setter
     * 
     * class, property, method, public field => PascalCase
     * private field => _camelCase
     * parameter, local variable => camelCase
     * 
     */

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1998, 11, 23));
            Console.WriteLine(person.GetBirthDate());
        }
    }

    class Person
    {
        private DateTime _birthdate;

        public Person()
        {

        }

        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthDate()
        {
            return _birthdate;
        }
    }
}
