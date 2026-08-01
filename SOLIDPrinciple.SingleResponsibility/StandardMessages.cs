using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciple.SingleResponsibility
{
    class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome To My Application");
        }

        public static void Message(string message)
        {
            Console.WriteLine("Please Enter " + message);
        }

        public static void ValidationMessage(string message)
        {
            Console.WriteLine("You did not give us a valid "+ message);
        }

        public static void EndMessage()
        {
            Console.WriteLine("");
        }

    }
}
