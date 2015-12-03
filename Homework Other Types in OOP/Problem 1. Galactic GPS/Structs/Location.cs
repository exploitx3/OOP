using System;
using System.Security.AccessControl;
using Problem_1.Galactic_GPS.Enums;

namespace Problem_1.Galactic_GPS.Structs
{
    public struct Location
    {
        private double latitude;
        private double longtitude;
        public Planet location { get; set; }


        public Location(double latitude, double longtitude, Planet location):this()
        {
            this.Latitude = latitude;
            this.Longtitude = longtitude;
            this.location = location;
        }
        

        public double Latitude
        {
            get { return this.latitude; }
            set
            {
                if (value < -90 || value > 90)
                {
                    throw new ArgumentOutOfRangeException("Latitude can be form -90 to 90.");
                }
                this.latitude = value;
            }
        }
        public double Longtitude
        {
            get { return this.longtitude; }
            set
            {
                if (value < -90 || value > 90)
                {
                    throw new ArgumentOutOfRangeException("Longtitude can be form -90 to 90.");
                }
                this.longtitude = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}, {1} - {2}", Latitude, Longtitude, this.location);
        }
    }
}