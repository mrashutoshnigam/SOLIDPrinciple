using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BridgePattern
{
    class BlueColorView : View
    {       
        public BlueColorView(IContent content):base(content)
        {
          
        }
        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(content.ReturnContent());
        }
    }
}
