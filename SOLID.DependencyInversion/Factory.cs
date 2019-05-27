using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DependencyInversion
{
    static class Factory
    {
        public static IPerson CreatePerson() => new Person();
        public static IChore CreateChore() => new Chore(CreateLogger(),CreateEmailHandler());
        public static ILogger CreateLogger() => new Logger();
        public static IMessageHandler CreateEmailHandler() => new Emailer();
    }
}
