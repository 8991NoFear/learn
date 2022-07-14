using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            Console.WriteLine(customer.Orders.Count());
        }
    }
}
