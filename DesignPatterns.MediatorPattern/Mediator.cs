namespace DesignPatterns.MediatorPattern
{
    internal class Mediator : IMediator
    {
        Flight flight;
        Runway runway;
        public bool CanLand { get; set; }

        public void SetFlight(Flight flight)
        {
            this.flight = flight;
        }

        public void SetRunway(Runway runway)
        {
            this.runway = runway;
        }
    }
}