using System;

namespace DesignPatterns.ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chain Of Responisibility!");
            NegativeNumber c1 = new NegativeNumber();
            PositiveNumber c2 = new PositiveNumber();
            ZeroNumber c3 = new ZeroNumber();
            c1.NextResponsibility(c2);
            c2.NextResponsibility(c3);
            c3.NextResponsibility(c1);

            c1.Handle(new Number(10));
            c1.Handle(new Number(-10));
            c1.Handle(new Number(0));
            c2.Handle(new Number(-5));

            Console.Read();
        }
    }
}
