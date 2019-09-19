using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BridgePattern
{
    class StringContent : IContent
    {
        public string ReturnContent()
        {
            return "Strings ..................";
        }
    }
}
