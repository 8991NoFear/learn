using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingAndDowncasting
{
    /*
     * Base class variable and derived class variable reference to the same object in heap but they have different view
     * => Because of that we have upcasting/downcasting concept
     * 
     * In the "inheritance hierarchy tree", start with the "actual type" of object
     * +, Go up to the ancestor: upcasting (implicit)
     * +, Go down to the descendant: downcasting (must explicit)
     * 
     * InvalidCastException may occur at runtime => use "as" keyword
     * 
     * The "is" keyword is identical as "instance of" keyword in Java
     */
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
