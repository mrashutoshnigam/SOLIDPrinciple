using System;

namespace DesignPatterns.AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adapter Pattern!");

            ITarget target = new Adapter(new Adaptee());
            Console.WriteLine(target.GetEmployeeInXML().ToString());

            Console.ReadLine();
        }
    }
}
