using System;
using DRY.Library;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace DRY.Test
{
   // [TestClass]
    public class EmployeeProcessorTest
    {
        //[TestMethod]
        [Theory]
        [InlineData("ashutosh","nigam","ashuniga")]
        [InlineData("rajeev", "ranjan", "rajeranj")]
        [InlineData("rit", "bhara", "ritbhar")]
        public void GenerateEmployeeIdTest(string firstName,string lastName,string exceptedresult)
        {
            string empId;
            EmployeeProcessor employeeProcessor = new EmployeeProcessor();
            empId= employeeProcessor.GenerateID(firstName,lastName);
            Assert.Equal(exceptedresult, empId);
        }
    }
}
