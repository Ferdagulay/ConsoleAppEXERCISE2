using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erdemOdev
{
    public interface IAlgorithm
    {
        Route findRoute(Vehicle v, Coordinate start, Coordinate end);
    }
}
