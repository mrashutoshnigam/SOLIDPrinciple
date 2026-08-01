using System;

namespace DesignPatterns.CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Command Pattern!");
            InvokerRemote remote = new InvokerRemote();
            remote.Add(new LightDevice());
            remote.Add(new LightDevice());
            remote.Add(new FanDevice());
            ConsoleKeyInfo Cons = new ConsoleKeyInfo();
            do
            {
                Console.Clear();
                if (Cons.Key == ConsoleKey.LeftArrow)
                    remote.ButtonOn();
                else if (Cons.Key == ConsoleKey.RightArrow)
                    remote.ButtonOff();
                else if (Cons.Key == ConsoleKey.UpArrow)
                    remote.UpPress();
                else if (Cons.Key == ConsoleKey.DownArrow)
                    remote.DownPress();
                Cons = Console.ReadKey();
            } while (Cons.Key != ConsoleKey.Q);
            Console.WriteLine("Program Exit");
            Console.ReadLine();
        }
    }
}
