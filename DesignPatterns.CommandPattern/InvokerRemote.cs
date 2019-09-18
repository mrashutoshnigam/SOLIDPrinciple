using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CommandPattern
{
    class InvokerRemote
    {
        IList<IOnOffDevices> OnOffDevices;
        IList<IFanSpeedDevice> fanSpeedDevices;
        public InvokerRemote()
        {
            OnOffDevices = new List<IOnOffDevices>();
            fanSpeedDevices = new List<IFanSpeedDevice>();
        }
        public void Add(IOnOffDevices dev)
        {
            this.OnOffDevices.Add(dev);
        }
        public void Add(IFanSpeedDevice fanSpeedDevices)
        {
            this.fanSpeedDevices.Add(fanSpeedDevices);
        }
        public InvokerRemote(IList<IOnOffDevices> onOffs)
        {
            OnOffDevices = onOffs;
        }
        public void ButtonOn()
        {
            foreach (var item in OnOffDevices)
            {
                item.On();
            }
            foreach (var item in fanSpeedDevices)
            {
                item.On();
            }
        }
        public void ButtonOff()
        {
            foreach (var item in OnOffDevices)
            {
                item.Off();
            }
            foreach (var item in fanSpeedDevices)
            {
                item.Off();
            }
        }
        public void UpPress()
        {
            foreach (var item in fanSpeedDevices)
            {
                item.SpeedUp();
            }
        }
        public void DownPress()
        {
            foreach (var item in fanSpeedDevices)
            {
                item.SpeedDown();
            }
        }

    }
}
