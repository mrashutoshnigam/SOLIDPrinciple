using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    class MacFactory : IControlFactory
    {
        public IButton CreateButton()
        {
            return new Mac.Button();
        }

        public IDialog CreateDialog()
        {
            return new Mac.Dialog() ;
        }

        public ILabel CreateLabel()
        {
            return new Mac.Label() ;
        }
    }
}
