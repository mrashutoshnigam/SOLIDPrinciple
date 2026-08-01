using System;
using System.Collections.Generic;
using System.Text;
using SOLIDPrinciple.OpenClose.Accounts;

namespace SOLIDPrinciple.OpenClose.Applicants
{
    class Manager : ApplicantAbstract
    {
        public override IAccount AccountManager { get; set; } = new Accounts.ManagerAccount();
    }
}
