using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.IteratorPattern
{
    class NotificationIterable : INotificationIterable
    {
        Notificaiton[] notificaitons;
        const int MAX = 10;
        int current = -1;
        public NotificationIterable()
        {
            this.notificaitons = new Notificaiton[MAX];
        }
        public void Add(string notificationContent)
        {
            var notificaiton = new Notificaiton(notificationContent);
            if (current < MAX)
            {
                this.notificaitons[current + 1] = notificaiton;
                current++;
            }

            else
                throw new IndexOutOfRangeException();
        }
        public INotificationIterator CreateIterator()
        {
            return new NotificationIterator(notificaitons);
        }
    }
}
