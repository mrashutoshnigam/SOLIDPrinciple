using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.IteratorPattern
{
    class Notificaiton
    {
        string Content;
        public Notificaiton(string content)
        {
            Content = content;
        }
        public string GetNotificationContent()
        {
            return this.Content;
        }
    }
}
