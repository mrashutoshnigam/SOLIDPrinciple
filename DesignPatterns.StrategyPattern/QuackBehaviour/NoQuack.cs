using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.QuackBehaviour
{
    class NoQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("No Quack");
        }
    }
}
