using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BridgePattern
{
    class NumbersContent : IContent
    {
        public string ReturnContent()
        {
            return "1,2,3,4,.....................";
        }
    }
}
