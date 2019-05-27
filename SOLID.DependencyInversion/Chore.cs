using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion
{
    public class Chore : IChore
    {
        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; private set; }
        public bool IsComplete { get; private set; }

        private ILogger _logger;
        private IMessageHandler _emailer;
        public Chore(ILogger logger, IMessageHandler emailer)
        {
            _logger = logger;
            _emailer = emailer;
        }

        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            _logger.Log($"Performed work on { ChoreName }");
        }

        public void CompleteChore()
        {
            IsComplete = true;

            _logger.Log($"Completed { ChoreName }");
            _emailer.SendMessage(Owner, $"The chore { ChoreName } is complete.");
        }
    }
}
