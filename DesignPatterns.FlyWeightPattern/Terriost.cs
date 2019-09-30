using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FlyWeightPattern
{
    class Terriost : IPlayer
    {
        readonly string TASK;
        string weapon;
        public Terriost()
        {
            TASK = "Plant Bomb";
        }
        public void AssignWeapon(string weapon)
        {
            this.weapon = weapon;
        }

        public void Mission()
        {
            Console.WriteLine($"Terriost with {weapon} to Complete Task: {TASK}");
        }
    }
}
