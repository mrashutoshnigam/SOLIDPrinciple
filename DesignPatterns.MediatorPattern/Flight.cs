namespace DesignPatterns.MediatorPattern
{
    internal class Flight : IAirCommand
    {
        IMediator mediator;
        public Flight(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public void Land()
        {
            if (mediator.CanLand)
            {
                System.Console.WriteLine("Flight: Flight Landed!");
            }
            else
            {
                System.Console.WriteLine("Flight: waiting for Landing");
            }
        }

    }
}