using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.FlyBehaviour
{
    class NoFly : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Can't Fly");
        }
    }
}
