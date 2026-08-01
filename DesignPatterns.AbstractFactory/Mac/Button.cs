using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory.Mac
{
    class Button:IButton
    {
        public override string ToString()
        {
            return "Mac Button";
        }
    }
}
