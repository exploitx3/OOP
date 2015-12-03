using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Problem_1.Galactic_GPS.Enums;
using Problem_1.Galactic_GPS.Structs;

namespace Problem_1.Galactic_GPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Location home = new Location(18.037986, 28.870097, Planet.Earth);
            Console.WriteLine(home);



        }
    }
}
