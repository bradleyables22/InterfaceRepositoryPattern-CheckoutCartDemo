using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib
{
    public class PhysicalProduct : IProduct
    {
        public string Title { get; set ; } = String.Empty;
        public bool HasOrderBeenCompleted { get; set; }

        public void ShipItem(Customer customer)
        {
            Console.WriteLine("Shipping " + Title + " to " + customer.Address + ".");
            HasOrderBeenCompleted = true;
            Console.WriteLine("Order Status: Complete.");
            Console.WriteLine();
        }
    }
}
