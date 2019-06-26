using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erdemOdev
{
    class TruckPath : IAlgorithm
    {
        public Route findRoute(Vehicle v , Coordinate start, Coordinate end)
        {

            Route r = new Route();

            r.addcoord(start);
            r.addcoord(551, 552);
            r.addcoord(558, 554);
            r.addcoord(end);
            return r;
        }
    }
}
