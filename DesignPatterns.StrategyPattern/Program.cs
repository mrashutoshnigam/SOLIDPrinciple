using System;

namespace DesignPatterns.StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Duck rubberDuck = new Duck("Rubber Duck",new QuackBehaviour.Quack(), new FlyBehaviour.NoFly());
            rubberDuck.Print();

            Duck wildDuck = new Duck("Wild Duck", new QuackBehaviour.Quack(), new FlyBehaviour.NormalFly());
            wildDuck.Print();

            Duck cityDuck = new Duck("City Duck", new QuackBehaviour.Quack(), new FlyBehaviour.JetFly());
            cityDuck.Print();

            Console.Read();
        }

    }
}
