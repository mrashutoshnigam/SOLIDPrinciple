namespace DesignPatterns.IteratorPattern
{
    interface INotificationIterator
    {
        bool HasNext();
        Notificaiton Get();
    }
}