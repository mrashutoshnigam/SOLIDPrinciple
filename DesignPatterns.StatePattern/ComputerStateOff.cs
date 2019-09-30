using System;

namespace DesignPatterns.StatePattern
{
    internal class ComputerStateOff : IComputerState
    {
        private ComputerContext context;

        public ComputerStateOff(ComputerContext context)
        {
            this.context = context;
            Console.WriteLine("Computer is Off..");
            System.Console.WriteLine("Press Any Key to Start Your Computer...");
        }

        public void DoAction()
        {            
            this.context.ChangeState(new ComputerStateOn(this.context));
            
        }
    }
}