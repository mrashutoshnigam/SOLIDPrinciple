using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BuilderPattern
{
    class WoodHouse : IHouse
    {
        public void BuildFloor()
        {
            Console.WriteLine("Wood Floor Build");
        }

        public void BuildRoof()
        {
            Console.WriteLine("Wood Roof Build");
        }

        public void BuildWalls()
        {
            Console.WriteLine("Wood Walls Build");
        }

        public void BuildWindows()
        {
            Console.WriteLine("Wood Windows/Doors Build");
        }
    }
}
