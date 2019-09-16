using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory.Linux
{
    class Label: ILabel
    {
        public override string ToString()
        {
            return "Linux Label";
        }
    }
}
