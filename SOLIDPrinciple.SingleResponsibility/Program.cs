using System;

namespace SOLIDPrinciple.SingleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            Person person = PersonDataCapture.Capture();

            if (!PersonDataValidator.Validate(person))
            {
                StandardMessages.EndMessage();
                return;
            }
            AccountGenerator.CreateUser(person);                     
            StandardMessages.EndMessage();
        }
    }
}
