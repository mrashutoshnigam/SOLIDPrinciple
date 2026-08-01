using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BridgePattern
{
    class RedColorView : View
    {
        
        public RedColorView(IContent content):base(content)
        {
            this.content = content;
        }
        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(content.ReturnContent());
        }
    }
}
