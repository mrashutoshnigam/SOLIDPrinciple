using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod
{
    public class Ship : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Delivery by Ship");
        }
    }
}