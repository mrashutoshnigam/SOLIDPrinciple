using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.IteratorPattern
{
    class NotificationIterator : INotificationIterator
    {
        Notificaiton[] notificaitons;
        int position = 0;
        public NotificationIterator(Notificaiton[] notificaitons)
        {
            this.notificaitons = notificaitons;
        }
        public Notificaiton Get()
        {
            var noti = notificaitons[position];
            position++;
            return noti;

        }

        public bool HasNext()
        {
            if (notificaitons.Length <= position || notificaitons == null || notificaitons[position] == null)
                return false;
            else
                return true;
        }
    }
}
