using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.VisitorPattern
{
    class MacOSVisitor : IVisitor
    {
        public void Visit(DLinkRouter dLinkRouter)
        {
            Console.WriteLine("MAC OS configured for DLink..");
            dLinkRouter.SendData();            
        }

        public void Visit(TPLinkRouter tPLinkRouter)
        {
            Console.WriteLine("MAC OS configured for TPLink..");
            tPLinkRouter.SendData();
        }
    }
}
