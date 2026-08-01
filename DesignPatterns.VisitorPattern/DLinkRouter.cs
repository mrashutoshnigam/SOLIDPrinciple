using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.VisitorPattern
{
    class DLinkRouter : IRouter
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
