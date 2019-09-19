using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BridgePattern
{
    abstract class View
    {
        protected IContent content;
        protected View(IContent content)
        {
            this.content = content;
        }
        public abstract void Show();
    }
}
