using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern
{
    abstract class AddOnsBeverage : Beverage
    {
        protected Beverage beverage;
    }
}
