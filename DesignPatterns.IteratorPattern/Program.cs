using System;

namespace DesignPatterns.IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iterator Pattern!");
            NotificationIterable notification = new NotificationIterable();
            notification.Add("ashutosh nigam");
            notification.Add("ritambhara nigam");
            notification.Add("arnav nigam");
            NotificationBar notificationBar = new NotificationBar(notification);
            notificationBar.ToString();
            Console.ReadLine();
        }
    }
}
