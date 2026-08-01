using System;

namespace DesignPatterns.StatePattern
{
    internal class ComputerStateShutdown : IComputerState
    {
        private ComputerContext context;

        public ComputerStateShutdown(ComputerContext context)
        {
            this.context = context;
            Console.WriteLine("Shuting down Computer............");
            System.Console.WriteLine("Press Any key to Start Computer..");
        }

        public void DoAction()
        {
            this.context.ChangeState(new ComputerStateOn(this.context));
        }
    }
}