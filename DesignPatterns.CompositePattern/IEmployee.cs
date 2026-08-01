using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CompositePattern
{
    interface IEmployee
    {
        string Name { get; set; }
        int Id { get; set; }
        void Display();
    }
}
