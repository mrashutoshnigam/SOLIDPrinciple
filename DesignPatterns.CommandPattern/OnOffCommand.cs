using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CommandPattern
{
    class OnOffCommand : ICommand
    {
        IOnOffDevices OnOffDevices;
        public OnOffCommand(IOnOffDevices OnOffDevices)
        {
            this.OnOffDevices = OnOffDevices;
        }
        public void Execute()
        {
            this.OnOffDevices.On();
        }

        public void UnExecute()
        {
            this.OnOffDevices.Off();
        }
    }
}
