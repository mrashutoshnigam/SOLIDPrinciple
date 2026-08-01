using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CommandPattern
{
    class FanDevice : IFanSpeedDevice
    {
        int i = 0;
        public void On()
        {
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.WriteLine("Fan On: *");
        }
        public void Off()
        {
            System.Console.ForegroundColor = System.ConsoleColor.Blue;
            System.Console.WriteLine("Fan Off: +");
        }

        public void SpeedUp()
        {
            On();
            System.Console.WriteLine("Speed++: " + ++i);
        }

        public void SpeedDown()
        {
            On();
            System.Console.WriteLine("Speed--: " + --i);
        }
    }
}
