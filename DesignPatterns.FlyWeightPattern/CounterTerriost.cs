using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FlyWeightPattern
{
    class CounterTerriost : IPlayer
    {
        readonly string TASK;
        string weapon;
        public CounterTerriost()
        {
            TASK = "Difuse Bomb";
        }
        public void AssignWeapon(string weapon)
        {
            this.weapon = weapon;
        }

        public void Mission()
        {
            Console.WriteLine($"Counter Terriost with {weapon} to Complete Task: {TASK}");
        }
    }
}
