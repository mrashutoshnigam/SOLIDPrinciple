using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciple.SingleResponsibility
{
    class PersonDataValidator
    {
        public static bool Validate(Person person)
        {
            if (string.IsNullOrEmpty(person.FirstName))
            {
                StandardMessages.ValidationMessage("First Name");
                return false;
            }
            if (string.IsNullOrEmpty(person.LastName))
            {
                StandardMessages.ValidationMessage("last name");
                return false;
            }
            return true;
        }
    }
}
