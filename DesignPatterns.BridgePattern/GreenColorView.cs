using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BridgePattern
{
    class GreenColorView:View
    {
     
        public GreenColorView(IContent content):base(content)
        {
            this.content = content;
        }
        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(content.ReturnContent());
        }
    }
}
