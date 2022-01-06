namespace AIHR.SolarSystem.Models;

public class DwarfPlanet : CelestialBody
{
    public DwarfPlanet()
    { }
    public DwarfPlanet(string name, string pictureFileName, long distanceFromSun, int orbitalPeriod, double mass) : base(name, pictureFileName, distanceFromSun, orbitalPeriod, mass) { }
}