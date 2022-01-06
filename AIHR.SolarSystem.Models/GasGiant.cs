namespace AIHR.SolarSystem.Models;

public class GasGiant : CelestialBody
{
    public GasGiant()
    { }
    public GasGiant(string name, string pictureFileName, long distanceFromSun, int orbitalPeriod, double mass) : base(name, pictureFileName, distanceFromSun, orbitalPeriod, mass) { }
}