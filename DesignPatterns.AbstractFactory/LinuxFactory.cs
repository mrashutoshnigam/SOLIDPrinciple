using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    class LinuxFactory : IControlFactory
    {
        public IButton CreateButton()
        {
            return new Linux.Button();
        }

        public IDialog CreateDialog()
        {
            return new Linux.Dialog();
        }

        public ILabel CreateLabel()
        {
            return new Linux.Label();
        }
    }
}
