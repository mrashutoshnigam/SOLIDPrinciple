using System;

namespace DesignPatterns.StatePattern
{
    internal class ComputerStateSleep : IComputerState
    {
        private ComputerContext context;

        public ComputerStateSleep(ComputerContext context)
        {
            this.context = context;
            Console.WriteLine("Sleeping Computer..........");
        }

        public void DoAction()
        {
            Console.WriteLine("Press any key to Resume your Computer..");
            Console.ReadLine();
            this.context.ChangeState(new ComputerStateOn(this.context));
        }
    }
}