using System;
using System.Collections.Generic;
using System.Text;
using SOLIDPrinciple.OpenClose.Applicants;

namespace SOLIDPrinciple.OpenClose.Accounts
{
    class ManagerAccount : IAccount
    {
        public EmployeeModel CreateEmployee(ApplicantAbstract applicant)
        {
            EmployeeModel employee = new EmployeeModel(applicant);
            employee.Salary = 10000000;
            return employee;
        }
    }
}
