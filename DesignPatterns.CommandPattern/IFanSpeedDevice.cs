using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CommandPattern
{
    interface IFanSpeedDevice : IOnOffDevices
    {
        void SpeedUp();
        void SpeedDown();
    }
}
