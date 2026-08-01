using System;

namespace DesignPatterns.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Logistics logistics = new RoadLogistics();
            ITransport transport = logistics.CreateTransport();
            transport.Deliver();
            Logistics logistics1 = new SeaLogistics();
            ITransport transport1 = logistics1.CreateTransport();
            transport1.Deliver();
            Console.Read();
        }
    }
}
