using System.Collections.Generic;

namespace Constructor
{
    class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders; // = new List<Order>();

        public Customer()
        {
            Orders = new List<Order>();
        }

        // unneccessary constructor
        public Customer(int id)
            : this() // best practices: non-default constructor should call other constructor
        {
            Id = id;
        }

        // unneccessary constructor
        public Customer(int id, string name)
            : this(id)
        {
            Name = name;
        }
    }
}
