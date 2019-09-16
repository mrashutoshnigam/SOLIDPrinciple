using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory.Windows
{
    class Label: ILabel
    {
        public override string ToString()
        {
            return "Windows Label";
        }
    }
}
