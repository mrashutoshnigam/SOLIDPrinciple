using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StatePattern
{
    class ComputerStateOn : IComputerState
    {
        ComputerContext context;
        public ComputerStateOn(ComputerContext context)
        {
            this.context = context;
            System.Console.WriteLine("Computer Started..........");
            Console.WriteLine("O: Hard Off\nS: Shoudown\nL: Sleep\nEnter Your Choice");
            DoAction();
        }
        public void DoAction()
        {         
            var ch = Console.ReadKey(true);
            switch (ch.Key)
            {
                case ConsoleKey.O:                    
                    context.ChangeState(new ComputerStateOff(context));
                    break;
                case ConsoleKey.S:
                    
                    context.ChangeState(new ComputerStateShutdown(context));
                    break;
                case ConsoleKey.L:                   
                    context.ChangeState(new ComputerStateSleep(context));
                    break;
                default:
                    break;
            }
        }
    }
}
