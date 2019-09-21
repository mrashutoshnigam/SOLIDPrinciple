using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CompositePattern
{
    class Manager : IEmployee
    {
        public string Name { get;set; }
        public int Id { get;set; }
     
        public IList<IEmployee> Employees { get; set; }
        public Manager(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            Employees = null;
        }
        public Manager(int id, string name, IList<IEmployee> employees) : this(id, name)
        {
            this.Employees = employees;
        }

        public void Display()
        {
            Console.WriteLine($"- Manager : {Id} , {Name}");
            foreach (var item in Employees)
            {
                item.Display();
            }
        }
    }
}
