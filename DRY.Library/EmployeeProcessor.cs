using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRY.Library
{
    public class EmployeeProcessor
    {
        public string GenerateID(string firstName,string lastName)
        {
            return $"{firstName.Substring(0, 4)}{lastName.Substring(0, 4)}";
        }
    }
}
