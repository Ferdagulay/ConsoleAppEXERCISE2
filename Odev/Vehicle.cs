using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erdemOdev
{
    public abstract class Vehicle
    {
        public abstract List<Coordinate> getBlockedPaths();
    }
}
