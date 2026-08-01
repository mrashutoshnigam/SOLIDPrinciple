using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciple.OpenClose
{
    class EmployeeModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }

        public EmployeeModel(Applicants.ApplicantAbstract applicant)
        {
            this.FirstName = applicant.FirstName;
            this.LastName = applicant.LastName;
            this.Position = applicant.GetType().Name;
            this.Email = $"{applicant.FirstName}.{applicant.LastName}@an.com";
            this.Salary = 0;
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}, Email: {Email}, Position: {Position}, Salary: {Salary}";
        }
    }
}
