namespace AIHR.SolarSystem.Models;

public class Star : CelestialBody
{
    public Star()
    { }
    public Star(string name, string pictureFileName, long distanceFromSun, int orbitalPeriod, double mass) : base(name, pictureFileName, distanceFromSun, orbitalPeriod, mass) { }
}