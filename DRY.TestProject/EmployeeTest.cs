using DRY.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DRY.TestProject
{
    public class EmployeeTest
    {
        [Theory]
        [InlineData("ashutosh", "nigam", "ashuniga")]
        [InlineData("rajeev", "ranjan", "rajeranj")]
        [InlineData("rit", "bhara", "ritbhar")]
        public void GenerateEmployeeIdTest(string firstName, string lastName, string exceptedresult)
        {
            string empId;
            EmployeeProcessor employeeProcessor = new EmployeeProcessor();
            empId = employeeProcessor.GenerateID(firstName, lastName);
            Assert.Equal(exceptedresult, empId);
        }
    }
}
