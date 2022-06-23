using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib
{
    public interface IProduct
    {
        string Title { get; set; }
        bool HasOrderBeenCompleted { get; set; }

        //Method of shipping will change depending if product is digital or physical.
        void ShipItem(Customer customer);
    }
}
