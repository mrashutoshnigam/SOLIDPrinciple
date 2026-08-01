using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StatePattern
{
    class GateContext
    {
        IGateState gateState;
        public GateContext()
        {
            gateState = new ClosedGateState();
        }
        void Payment()
        {

        }
        void PaymentOK()
        {

        }
        void PaymentFailed()
        {

        }
        void GoNext()
        {

        }
    }
}
