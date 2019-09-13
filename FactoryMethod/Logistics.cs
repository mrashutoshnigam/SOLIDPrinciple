using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod
{
    class Logistics
    {
        public virtual ITransport CreateTransport()
        {
            return null;
        }
        public void PlanDelivery()
        {           
            Console.WriteLine("Plan Delivery");
        }
    }
}
