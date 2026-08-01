using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory.Windows
{
    class Dialog:IDialog
    {
        public override string ToString()
        {
            return "Windows Dialog";
        }
    }
}
