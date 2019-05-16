using System;
using System.Collections.Generic;
using System.Text;
using SOLIDPrinciple.OpenClose.Applicants;

namespace SOLIDPrinciple.OpenClose.Accounts
{
    class JoniorDeveloperAccount : IAccount

    {
        public EmployeeModel CreateEmployee(ApplicantAbstract applicant)
        {
            EmployeeModel employee = new EmployeeModel(applicant);
            employee.Salary = 500000;
            return employee;
        }
    }
}
