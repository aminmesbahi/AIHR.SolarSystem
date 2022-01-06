namespace AIHR.SolarSystem.Models;

public static class PlanetExtensions
{
    public static string Colonize(this CelestialBody celestialBody)
    {
        return $"{celestialBody.Name} has been Colonized by an ExtensionMethod :)";
    }
}