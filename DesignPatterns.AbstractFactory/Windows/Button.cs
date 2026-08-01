using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory.Windows
{
    class Button:IButton
    {
        public override string ToString()
        {
            return "Windows Button";
        }
    }
}
