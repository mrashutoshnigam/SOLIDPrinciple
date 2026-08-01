using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern
{
    class Espresso : Beverage
    {
        public override string Description()
        {
            return this.GetType().Name;
        }
        public override int Cost()
        {
            return 1;
        }
    }
}
