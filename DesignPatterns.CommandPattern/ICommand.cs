using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CommandPattern
{
    interface ICommand
    {
        void Execute();
        void UnExecute();
    }
}
