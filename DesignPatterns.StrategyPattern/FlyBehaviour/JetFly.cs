using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.FlyBehaviour
{
    class JetFly : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Flying as Jet");
        }
    }
}
