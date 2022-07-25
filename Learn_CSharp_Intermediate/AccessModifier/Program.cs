using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    /*
     * What?
     *  +, public: accessible from anywhere
     *  +, private: accessible only from class
     *  +, protected: accessible from same class and derived classes
     *  +, internal: accessible only from same assembly (domain) (offen use only for class)
     *  +, protected internal: accessible only from same assembly and derived classes (WEIRD!)
     * 
     * Why? Encapsulation (or information hiding):
     * Blackbox metaphore: "The more class reveal its internal implementation the more risky when we're going to change that class"
     * 
     * How? private for field and public for getter/setter
     * 
     * Naming convention:
     * +, class, property, method, public field => PascalCase
     * +, private field => _camelCase
     * +, parameter, local variable => camelCase
     */

    class Program
    {
        static void Main(string[] args)
        {
            // var person = new Person();
            // person.SetBirthdate(new DateTime(1998, 11, 23));
            // Console.WriteLine(person.GetBirthDate());
            
            var customer = new GoldCustomer() { Id = 1, Name = "Mosh", ParticipationAt = new DateTime(2020, 11, 23) };
            customer.Promote();
            customer.offerInterestRate();
        }
    }
}
