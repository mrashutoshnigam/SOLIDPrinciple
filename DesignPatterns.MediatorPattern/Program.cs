using System;

namespace DesignPatterns.MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mediator Pattern!");
            IMediator mediator = new Mediator();
            Flight flight = new Flight(mediator);
            Runway runway = new Runway(mediator);
            mediator.SetFlight(flight);
            mediator.SetRunway(runway);
            flight.Land();
            mediator.CanLand = true;
           // runway.SetLandingStatus(true);
            runway.Land();
            flight.Land();
            Console.Read();
        }
    }
}
