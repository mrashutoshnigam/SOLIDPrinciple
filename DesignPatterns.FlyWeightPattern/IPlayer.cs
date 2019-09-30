using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FlyWeightPattern
{
    interface IPlayer
    {
        void AssignWeapon(string weapon);
        void Mission();
    }
}
