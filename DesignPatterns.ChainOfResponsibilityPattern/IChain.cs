using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern
{
    interface IChain
    {
        void NextResponsibility(IChain NextChain);
        void Handle(Number number);
    }
}
