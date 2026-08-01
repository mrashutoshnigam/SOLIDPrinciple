using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.TemplateMethodPattern
{
    class StringDisplay : DisplayFormat
    {
        
        protected override string GetData()
        {
            return "Strings";
        }
    }
}
