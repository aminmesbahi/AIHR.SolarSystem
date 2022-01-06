namespace AIHR.SolarSystem.Models
{
    
    public abstract class CelestialBody : IPlanet
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        protected CelestialBody(){}
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        protected CelestialBody(string name, string pictureFileName, long distanceFromSun, int orbitalPeriod, double mass)
        {
            Name = name;
            PictureFileName = pictureFileName;
            DistanceFromSun = distanceFromSun;
            OrbitalPeriod = orbitalPeriod;
            Mass = mass;
        }
        public string Name { get; set; }
        public string PictureFileName { get; set; }
        public long DistanceFromSun { get; set; }
        public int OrbitalPeriod { get; set; }
        public double Mass { get; set; }

        #region IPlanet Members
        public bool CanSustainLife { get; set; }
        public bool CanBeTerraformed { get; set; }
        public bool HasSatelliteMoon { get; set; }
        #endregion
    }
}