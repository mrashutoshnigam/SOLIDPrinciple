using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciple.OpenClose.Applicants
{
    abstract class ApplicantAbstract
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public abstract OpenClose.Accounts.IAccount AccountManager { get; set; }
    }
}
