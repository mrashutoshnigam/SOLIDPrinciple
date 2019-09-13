using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.FlyBehaviour
{
    class NormalFly : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Normal Flying");
        }
    }
}
