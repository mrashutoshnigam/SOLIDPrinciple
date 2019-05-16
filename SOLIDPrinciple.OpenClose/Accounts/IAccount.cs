using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciple.OpenClose.Accounts
{
    interface IAccount
    {
        EmployeeModel CreateEmployee(OpenClose.Applicants.ApplicantAbstract applicant);
    }
}
