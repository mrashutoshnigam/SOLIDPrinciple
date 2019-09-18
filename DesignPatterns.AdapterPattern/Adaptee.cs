using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AdapterPattern
{
    class Adaptee
    {
        Employee emp;
        public Adaptee()
        {
            emp = new Employee()
            {
                Id = 1,
                Name = "Ashutosh Nigam",
                Address = "Hyderabad, India",
                ContactNo = "+919630747751"
            };
        }
        public Employee GetEmployee() => emp;
    }
}
