using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod
{
    class Truck : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Delivery by Truck");
        }
    }
}
