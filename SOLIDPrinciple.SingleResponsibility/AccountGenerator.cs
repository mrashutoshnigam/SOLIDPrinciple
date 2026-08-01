using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciple.SingleResponsibility
{
    class AccountGenerator
    {
        public static void CreateUser(Person person)
        {
            Console.WriteLine("Your User Name is " + person.FirstName[0] + person.LastName);
        }
    }
}
