using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class Truck : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Delivery by Truck");
        }
    }
}
