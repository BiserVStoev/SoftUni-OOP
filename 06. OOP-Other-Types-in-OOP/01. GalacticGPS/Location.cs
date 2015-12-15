using System;

namespace _01.GalacticGPS
{
    public struct Location
    {
        private const int LatitudeMin = -90;
        private const int LatitudeMax = 90;
        private const int LongitudeMin = -180;
        private const int LongitudeMax = 180;

        private double latitude;
        private double longtitude;
        private Planet planetName;

        public Location(double latitude, double longitude, Planet planet) : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Planet = planet;
        }

        public double Latitude
        {
            get
            {
                return this.latitude;
            }

            private set
            {
                if (value < LatitudeMin || value > LatitudeMax)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Latitude must be in range {0} - {1}", LatitudeMin, LatitudeMax));
                }

                this.latitude = value;

            }
        }

        public double Longitude
        {
            get
            {
                return this.longtitude;

            }

            private set
            {
                if (value < LongitudeMin || value > LongitudeMax)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Longtitude must be in range {0} - {1}", LongitudeMin, LongitudeMax));
                }

                this.longtitude = value;

            }
        }

        public Planet Planet
        {
            get
            {
                return this.planetName;

            }

            private set
            {

                if (!Enum.IsDefined(typeof(Planet), value))
                {
                    throw new ArgumentException(string.Format("Invalid planet name - {0}.", value));
                }

                this.planetName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1} - {2}", this.Latitude, this.Longitude, this.Planet);
        }
    }
}
