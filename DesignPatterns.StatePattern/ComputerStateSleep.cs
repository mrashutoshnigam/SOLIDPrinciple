using System;

namespace DesignPatterns.StatePattern
{
    internal class ComputerStateSleep : IComputerState
    {
        private ComputerContext context;

        public ComputerStateSleep(ComputerContext context)
        {
            this.context = context;
            Console.WriteLine("Computer in Sleep Mode..........");
            Console.WriteLine("Press any key to Resume your Computer..");
        }

        public void DoAction()
        {
            this.context.ChangeState(new ComputerStateOn(this.context));
        }
    }
}