using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.VisitorPattern
{
    class LinuxVisitor : IVisitor
    {
        public void Visit(DLinkRouter dLinkRouter)
        {
            Console.WriteLine("Linux OS configured for DLink..");
            dLinkRouter.SendData();
        }

        public void Visit(TPLinkRouter tPLinkRouter)
        {
            Console.WriteLine("Linux OS configured for TPLink..");
            tPLinkRouter.SendData();
        }

    }
}
