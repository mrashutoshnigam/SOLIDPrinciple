using System;

namespace DesignPatterns.StatePattern
{
    internal class ComputerStateOff : IComputerState
    {
        private ComputerContext context;

        public ComputerStateOff(ComputerContext context)
        {
            this.context = context;
            Console.WriteLine("Force Off Computer..");
        }

        public void DoAction()
        {
            System.Console.WriteLine("Press Any Key to Start Your Computer...");
            System.Console.ReadLine();
            this.context.ChangeState(new ComputerStateOn(this.context));
            
        }
    }
}