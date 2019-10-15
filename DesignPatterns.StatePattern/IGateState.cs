using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StatePattern
{
    interface IGateState
    {
        void Payment();
        void PaymentOK();
        void PaymentFailed();
        void GoNext();
    }
}
