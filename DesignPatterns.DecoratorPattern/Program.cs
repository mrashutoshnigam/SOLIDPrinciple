using System;

namespace DesignPatterns.DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design Patterns : Decorator Pattern");

            Beverage espresso = new Espresso();
            Console.WriteLine(espresso.Description() + ": " + espresso.Cost());

            Beverage decaf = new Decaf();
            Console.WriteLine(decaf.Description() + ": " + decaf.Cost());

            Beverage carEss = new CaramelAddOns(espresso);
            Console.WriteLine(carEss.Description() + ": " + carEss.Cost());

            Beverage soycarEss = new SoyAddOns(carEss);
            Console.WriteLine(soycarEss.Description() + ": " + soycarEss.Cost());

            Beverage soydec = new SoyAddOns(decaf);
            Console.WriteLine(soydec.Description() + ": " + soydec.Cost());

            Console.ReadLine();
        }
    }
}
