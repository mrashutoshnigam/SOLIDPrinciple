using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory.Mac
{
    class Label: ILabel
    {
        public override string ToString()
        {
            return "Mac Label";
        }
    }
}
