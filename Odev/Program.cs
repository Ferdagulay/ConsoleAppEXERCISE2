using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erdemOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinate start = new Coordinate(1, 1);
            Coordinate end = new Coordinate(3, 3);
            IAlgorithm sp;
            Vehicle v = new Truck();
            if (new Random().NextDouble() > 0.5)
            {
                sp = new ShortestPath();
                Console.WriteLine("Shortest path");
            }
            else
            {
                sp = new TruckPath();
                Console.WriteLine("Truck path");
            }

            Route shortestRoute = sp.findRoute(v, start, end);

            shortestRoute.printCoord();

            Console.WriteLine();
            Console.ReadKey();


        }
    }
}
