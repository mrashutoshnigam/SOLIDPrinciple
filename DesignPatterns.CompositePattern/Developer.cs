using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CompositePattern
{
    class Developer : IEmployee
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Developer(int id, string name)
        {
            this.Id = id;
            this.Name = name;           
        }
       

        public void Display()
        {
            Console.WriteLine($" - Developer : {Id} , {Name}");            
        }
    }
}
