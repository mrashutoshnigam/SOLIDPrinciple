using System;

namespace DesignPatterns.BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Builder Design Pattern!");
            WoodHouse wood = new WoodHouse();

            Engineer engineer = new Engineer(wood);

            engineer.Build();

            Console.ReadLine();
        }
    }
}
