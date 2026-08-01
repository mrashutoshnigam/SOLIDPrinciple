using DesignPatterns.StrategyPattern.FlyBehaviour;
using DesignPatterns.StrategyPattern.QuackBehaviour;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern
{
    class Duck
    {
        IQuackBehaviour quackBehaviour;
        IFlyBehaviour flyBehaviour;
        string Name;
        public Duck(string name,IQuackBehaviour quack,IFlyBehaviour fly)
        {
            Name = name;
            quackBehaviour = quack;
            flyBehaviour = fly;
        }
        public void Fly()
        {
            flyBehaviour.Fly();
        }
        public void Quack()
        {
            quackBehaviour.Quack();
        }
        public override string ToString()
        {
            return base.ToString();
        }

        public void Print()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(this.Name);
            this.Fly();
            this.Quack();
        }
    }
}
