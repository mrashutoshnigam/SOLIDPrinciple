using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.TemplateMethodPattern
{
    abstract class DisplayFormat
    {
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(GetData());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(GetData());
        }
        protected abstract string GetData();

    }
}
