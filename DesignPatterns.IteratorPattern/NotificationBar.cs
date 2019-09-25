using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.IteratorPattern
{
    class NotificationBar
    {
        NotificationIterable NotificationIterable;
        public NotificationBar(NotificationIterable notificationIterable)
        {
            this.NotificationIterable = notificationIterable;
        }
        public override string ToString()
        {
            var iterator = this.NotificationIterable.CreateIterator();
            while (iterator.HasNext())
            {
                Notificaiton noti = iterator.Get();
                Console.WriteLine(noti.GetNotificationContent());
            }
            return string.Empty;
        }
    }
}
