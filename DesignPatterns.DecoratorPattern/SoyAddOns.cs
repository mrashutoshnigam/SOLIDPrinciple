using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern
{
    class SoyAddOns: AddOnsBeverage
    {
        public SoyAddOns(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string Description()
        {
            return this.beverage.Description() + " + " + this.GetType().Name;
        }
        public override int Cost()
        {
            return this.beverage.Cost() + 4;
        }
    }
}
