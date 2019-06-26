using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erdemOdev
{
    class Truck : Vehicle
    {
        public override List<Coordinate> getBlockedPaths()
        {
            List<Coordinate> blocked = new List<Coordinate>();

            blocked.Add(new Coordinate(551, 552));
            return blocked;
        }
    }
}
