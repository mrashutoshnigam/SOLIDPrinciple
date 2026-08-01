using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory.Linux
{
    class Dialog:IDialog
    {
        public override string ToString()
        {
            return "Linux Dialog";
        }
    }
}
