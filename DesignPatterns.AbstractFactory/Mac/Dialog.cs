using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory.Mac
{
    class Dialog:IDialog
    {
        public override string ToString()
        {
            return "Mac Dialog";
        }
    }
}
