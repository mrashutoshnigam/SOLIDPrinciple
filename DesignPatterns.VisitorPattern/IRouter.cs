using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.VisitorPattern
{
    abstract class IRouter
    {
        public void SendData()
        {
            Console.WriteLine("Sending Data....");
        }
        public void ReceiveData()
        {
            Console.WriteLine("Receiving Data...");
        }
        public abstract void Accept(IVisitor visitor);
    }
}
