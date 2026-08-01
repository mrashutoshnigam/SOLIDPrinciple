using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    class WindowsFactory : IControlFactory
    {
        public IButton CreateButton()
        {
            return new Windows.Button() ;
        }

        public IDialog CreateDialog()
        {
            return new Windows.Dialog();
        }

        public ILabel CreateLabel()
        {
            return new Windows.Label();
        }
    }
}
