using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern
{
    class NegativeNumber : IChain
    {
        IChain chain;
        public void NextResponsibility(IChain NextChain)
        {
            chain = NextChain;
        }

        public void Handle(Number number)
        {
            if (number.GetNumber() < 0)
                Console.WriteLine("Negative Number : " + number.GetNumber());
            else
                chain.Handle(number);
        }
    }
}
