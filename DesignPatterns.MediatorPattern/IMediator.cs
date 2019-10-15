namespace DesignPatterns.MediatorPattern
{
    internal interface IMediator
    {
        void SetRunway(Runway runway);
        void SetFlight(Flight flight);
        bool CanLand { get; set; }       
    }
}