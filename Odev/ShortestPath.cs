using System;
using System.Collections.Generic;

namespace erdemOdev
{
    public class ShortestPath : IAlgorithm
    {
        public ShortestPath()
        {
        }

        public Route findRoute(Vehicle v, Coordinate start, Coordinate end)
        {
            Route r = new Route();

            List<Coordinate> toBeAdded = new List<Coordinate>();

            toBeAdded.Add(new Coordinate(1, 2));
            toBeAdded.Add(new Coordinate(3, 4));
            toBeAdded.Add(new Coordinate(551, 552));
            toBeAdded.Add(new Coordinate(553, 554));

            r.addcoord(start);
            foreach (Coordinate t in toBeAdded)
            {
                if (!v.getBlockedPaths().Contains(t))
                    r.addcoord(t);
                else
                    Console.WriteLine("kapalı yol: " + t);
            }
            r.addcoord(end);
            return r;

        }
    }
}