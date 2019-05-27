using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciple.LiskovSubstitution
{
    class Employee : BaseEmployee, IManaged
    {
        public IEmployee Manager { get; set; } = null;
        public virtual void AssignManager(IEmployee manager)
        {
            // Simulate doing other tasks here - otherwise, this should be
            // a property set statement, not a method.
            Manager = manager;
        }
    }
}
