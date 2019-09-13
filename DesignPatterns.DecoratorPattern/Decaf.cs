using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern
{
    class Decaf : Beverage
    {
        public override string Description()
        {
            return this.GetType().Name;
        }
        public override int Cost()
        {
            return 2;
        }
    }
}
