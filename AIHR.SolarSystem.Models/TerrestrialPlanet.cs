namespace AIHR.SolarSystem.Models;

public class TerrestrialPlanet : CelestialBody
{
    public TerrestrialPlanet()
    { }
    public TerrestrialPlanet(string name, string pictureFileName, long distanceFromSun, int orbitalPeriod, double mass) : base(name, pictureFileName, distanceFromSun, orbitalPeriod, mass) { }
}