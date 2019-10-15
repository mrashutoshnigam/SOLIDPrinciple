namespace DesignPatterns.MediatorPattern
{
    internal class Runway : IAirCommand
    {
        IMediator mediator;
        public Runway(IMediator mediator)
        {
            this.mediator = mediator;            
        }
        public void SetLandingStatus(bool land)
        {
            this.mediator.CanLand = land;
        }

        public void Land()
        {
            if (this.mediator.CanLand)
            {
                System.Console.WriteLine("Runway: Ready For Landing..");
            }
            else
            {
                System.Console.WriteLine("Runway: Wait For Landing...");
            }
        }
    }
}