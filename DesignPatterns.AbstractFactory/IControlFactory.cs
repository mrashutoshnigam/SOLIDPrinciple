using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    interface IControlFactory
    {
        IDialog CreateDialog();
        IButton CreateButton();
        ILabel CreateLabel();
    }
}
