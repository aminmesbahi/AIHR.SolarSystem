namespace AIHR.SolarSystem.Models;

public class IceGiants : CelestialBody
{
    public IceGiants()
    { }
    public IceGiants(string name, string pictureFileName, long distanceFromSun, int orbitalPeriod, double mass) : base(name, pictureFileName, distanceFromSun, orbitalPeriod, mass) { }
}