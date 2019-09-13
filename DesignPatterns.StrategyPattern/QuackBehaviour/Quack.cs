using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.QuackBehaviour
{
    class Quack : IQuackBehaviour
    {
        void IQuackBehaviour.Quack()
        {
            Console.WriteLine("Quacking");
        }
    }
}
