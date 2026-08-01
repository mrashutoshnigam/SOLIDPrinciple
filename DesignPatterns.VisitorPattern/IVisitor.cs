namespace DesignPatterns.VisitorPattern
{
    interface IVisitor
    {
        void Visit(DLinkRouter dLinkRouter);
        void Visit(TPLinkRouter tPLinkRouter);
    }
}