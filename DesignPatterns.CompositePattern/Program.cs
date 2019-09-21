using System;
using System.Collections.Generic;

namespace DesignPatterns.CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Composite Pattern!");

            IEmployee dev1 = new Developer(4, "Developer 1");
            IEmployee dev2 = new Developer(5, "Developer 2");
            IEmployee dev3 = new Developer(6, "Developer 3");
            IEmployee dev4 = new Developer(7, "Developer 4");

            IList<IEmployee> list1 = new List<IEmployee>();
            list1.Add(dev1);
            list1.Add(dev2);
            list1.Add(dev3);
            list1.Add(dev4);

            IList<IEmployee> list2 = new List<IEmployee>()
            {
                 new Developer(8, "Developer 5"),
                 new Developer(9, "Developer 6")
            };


            IEmployee manager1 = new Manager(2, "Manager 1", list1);
            IEmployee manager2 = new Manager(3, "Manager 2", list2);

            IEmployee ceo = new CEO(1, "CEO", new List<IEmployee>() { manager1, manager2 });

            ceo.Display();

            Console.Read();
        }
    }
}
