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
                exit = Console.ReadKey();
                if (exit.Key == ConsoleKey.D)
                    this.computerState.DoAction();
                else
                    Console.WriteLine(this.computerState.ToString());

            } while (exit.Key != ConsoleKey.Escape);
         
        }
    }
}
