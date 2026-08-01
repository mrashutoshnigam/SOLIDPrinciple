using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory.Linux
{
    class Button:IButton
    {
        public override string ToString()
        {
            return "Linux Button";
        }
    }
}
