using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern
{
    abstract class Beverage
    {
        public virtual string Description()
        {
            return this.GetType().Name;
        }
        public abstract int Cost();
    }
}
