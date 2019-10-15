namespace DesignPatterns.StatePattern
{
    internal class ClosedGateState : IGateState
    {
        GateContext context;
        public ClosedGateState(GateContext context)
        {
            this.context = context;
        }
        public void GoNext()
        {
            throw new System.NotImplementedException();
        }

        public void Payment()
        {
            throw new System.NotImplementedException();
        }

        public void PaymentFailed()
        {
            throw new System.NotImplementedException();
        }

        public void PaymentOK()
        {
            throw new System.NotImplementedException();
        }
    }
}