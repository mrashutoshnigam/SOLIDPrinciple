using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class SeaLogistics : Logistics
    {
        public override ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}
