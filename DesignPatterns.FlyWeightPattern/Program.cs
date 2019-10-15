using System;

namespace DesignPatterns.FlyWeightPattern
{
    class Program
    {

        static void Main(string[] args)
        {
            // Use sharing to support large number of objects of same type
            Console.WriteLine("Fly Weight Pattern!");
            Console.WriteLine("Counter Strike");

            PlayersFatory players = new PlayersFatory();
            IPlayer p1 = players.GetPlayer("terriost");
            IPlayer p2 = players.GetPlayer("counterterriost");
            IPlayer p3 = players.GetPlayer("terriost");
            p1.AssignWeapon("AK-47");
            p2.AssignWeapon("Bomb Difusser");
            p1.Mission();
            p2.Mission();
            p3.Mission();
            Console.Read();
        }
    }
}
