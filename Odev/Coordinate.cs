using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erdemOdev
{
    public class Coordinate
    {
        private double x;
        private double y;

       public Coordinate(double a, double b)
        {
            this.x = a;
            this.y = b;
        }

        public override string ToString()
        {
            return "x: " + x + "     y: " + y;
        }

        public override bool Equals(object obj)
        {
            Coordinate o = (Coordinate)obj;
            return this.x == o.x && this.y == o.y;
        }
    }
}
