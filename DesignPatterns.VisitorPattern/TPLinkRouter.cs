using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.VisitorPattern
{
    class TPLinkRouter : IRouter
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
