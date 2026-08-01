using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BuilderPattern
{
    interface IHouse
    {
        void BuildRoof();
        void BuildWindows();
        void BuildWalls();
        void BuildFloor();
    }
}
