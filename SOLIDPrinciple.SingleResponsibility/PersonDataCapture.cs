using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciple.SingleResponsibility
{
    class PersonDataCapture
    {
        public static Person Capture()
        {
            Person person = new Person();
            StandardMessages.Message("first Name");
            person.FirstName = Console.ReadLine();
            StandardMessages.Message("last Name");
            person.LastName = Console.ReadLine();
            return person;
        }
    }
}
