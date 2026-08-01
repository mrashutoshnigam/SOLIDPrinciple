using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StatePattern
{
    class ComputerContext
    {
        IComputerState computerState;
        public void ChangeState(IComputerState computerState)
        {
            this.computerState = computerState;
            DoAction();
        }

        private void DoAction()
        {
            var exit = Console.ReadKey();
            do
            {
                exit = Console.ReadKey(true);
                if (exit.Key == ConsoleKey.Enter)
                {
                    this.computerState.DoAction();
                }
            } while (exit.Key != ConsoleKey.Escape);
        }
    }
}
