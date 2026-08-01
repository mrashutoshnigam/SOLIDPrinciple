using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciple.LiskovSubstitution
{
    public abstract class BaseEmployee : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public IEmployee Manager { get; set; } = null;
        public decimal Salary { get; set; }

        public virtual void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 12.50M;

            Salary = baseAmount + (rank * 2);
        }
    }
}
