using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.TemplateMethodPattern
{
    class NumberDisplay : DisplayFormat
    {
        protected override string GetData()
        {
            return "1,2,3,4";
        }
    }
}
