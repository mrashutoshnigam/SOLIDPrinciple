using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern
{
    class Number
    {
        int num;
        public Number(int num)
        {
            this.num = num;
        }
        public int GetNumber()
        {
            return num;
        }
    }
}
