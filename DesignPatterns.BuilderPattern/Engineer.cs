using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BuilderPattern
{
    class Engineer
    {
        IHouse house;
        public Engineer(IHouse house)
        {
            this.house = house;
        }
        public void Build()
        {
            this.house.BuildFloor();
            this.house.BuildWalls();
            this.house.BuildRoof();
            this.house.BuildWindows();
        }
    }
}
