using System.Collections.Generic;

namespace Field
{
    class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders;
        // #1
        //public readonly List<Order> Orders = new List<Order>();

        public Customer()
        {
            // #2
            Orders = new List<Order>();
        }

        public Customer(int id)
            : this()
        {
            Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            Name = name;
        }

        public void Promote()
        {
            // Error
            //Orders = new List<Order>();
        }
    }
}
