using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BuilderPattern
{
    class CementHouse : IHouse
    {
        public void BuildFloor()
        {
            Console.WriteLine("Cement Floor Build");
        }

        public void BuildRoof()
        {
            Console.WriteLine("Cement Roof Build");
        }

        public void BuildWalls()
        {
            Console.WriteLine("Cement Walls Build");
        }

        public void BuildWindows()
        {
            Console.WriteLine("Windows/Doors Build");
        }
    }
}
