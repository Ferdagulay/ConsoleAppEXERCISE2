using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erdemOdev
{
    public class Route
    {
       private List<Coordinate> coordinates;

       public Route ()
        {
            this.coordinates = new List<Coordinate>();

        }

        public void addcoord(Coordinate item)
        {
            this.coordinates.Add(item);
        }

        public void addcoord(double a, double b)
        {

            Coordinate item = new Coordinate(a, b);

            addcoord(item);
            //this.coordinates.Add(item);

        }

        public void printCoord()
        {
            foreach (Coordinate item in this.coordinates)
            {
                Console.WriteLine(item);
            }
        }
    }
}
