namespace SOLIDPrinciple.LiskovSubstitution
{
    interface IManaged
    {
        IEmployee Manager { get; set; }

        void AssignManager(IEmployee manager);
    }
}