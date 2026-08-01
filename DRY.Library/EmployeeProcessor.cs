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
            return $"{SubStr(firstName)}{SubStr(lastName)}";
        }
        private string SubStr(string str)
        {
            return str.Length >= 4 ? str.Substring(0, 4) : str;
        }
    }
}
