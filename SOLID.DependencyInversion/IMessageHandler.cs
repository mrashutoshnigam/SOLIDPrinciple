namespace SOLID.DependencyInversion
{
    public interface IMessageHandler
    {
        void SendMessage(IPerson person, string message);
    }
}