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
        }

        public void DoAction()
        {
            System.Console.WriteLine("Press Any key to Start Computer..");
            Console.Read();
            this.context.ChangeState(new ComputerStateOn(this.context));
        }
    }
}