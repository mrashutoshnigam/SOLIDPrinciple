using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern
{
    class ZeroNumber : IChain
    {
        IChain chain;
        public void NextResponsibility(IChain NextChain)
        {
            this.chain = NextChain;
        }

        public void Handle(Number number)
        {
            if (number.GetNumber() == 0)
                Console.WriteLine("Zero Number : " + number.GetNumber());
            else
                chain.Handle(number);
        }
    }
}
