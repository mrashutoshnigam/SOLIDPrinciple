using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.IteratorPattern
{
    interface INotificationIterable
    {
        INotificationIterator CreateIterator();
    }
}
