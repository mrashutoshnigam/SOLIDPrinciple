using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
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
