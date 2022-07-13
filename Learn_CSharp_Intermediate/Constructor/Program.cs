using System;
using System.Collections.Generic;

namespace Constructor
{
    /*
     * What? Constructor is a method that is called when an instance of a class is created
     * 
     * Why? To put object in early state (to initialize fields)
     * 
     * How? "Exactly same as in Java":
     *  +, Syntax ...
     *  +, Default initialize for fields: number => 0, object reference (including string) => null, character => '\0'
     *  +, Default constructor ...
     *  +, Contructor overloading ...
     *  
     *  Best practices? Only create constructor when we really need to put object to wanted early state
     */
    partial class Program
    {

        static void Main(string[] args)
        {
            var customer = new Customer();
            // If we don't init Orders we will get NullReferenceException, but we should not init Orders here also
            // Because Program class doesn't have responsibility for order, and if we ommit that and try do this
            // When the application become bigger we have to remember all place where we init Orders => awful
            //customer.Orders = new List<Order>();
            customer.Orders.Add(new Order()); 
        }
    }
}
