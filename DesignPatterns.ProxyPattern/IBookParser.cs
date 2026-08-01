using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ProxyPattern
{
    interface IBookParser
    {
        int NoOfPages { get;  }
        int NoOfWords { get;  }
    }
}
