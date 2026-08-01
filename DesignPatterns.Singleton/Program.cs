using System;

namespace DesignPatterns.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singleton Pattern!");
            Singleton sid = new Singleton(19);
            Singleton sin = Singleton.GetInstance();
            Console.WriteLine(sin.ToString());
            
            Console.ReadLine();
        }
    }
}
