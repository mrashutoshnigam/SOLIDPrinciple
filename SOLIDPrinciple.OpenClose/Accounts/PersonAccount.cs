using System;
using System.Collections.Generic;
using System.Text;
using SOLIDPrinciple.OpenClose.Applicants;

namespace SOLIDPrinciple.OpenClose.Accounts
{
    class PersonAccount : IAccount
    {
        public EmployeeModel CreateEmployee(ApplicantAbstract applicant)
        {
            EmployeeModel employee = new EmployeeModel(applicant);
            employee.Email = "";
            employee.Salary = 0;
            return employee;
        }
    }
}
