using System;

namespace DesignPatterns.StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("State Pattern!");
            ComputerContext computer = new ComputerContext();
            computer.ChangeState(new ComputerStateOff(computer));
            Console.ReadLine();
        }
    }
}
