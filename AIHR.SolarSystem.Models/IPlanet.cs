namespace AIHR.SolarSystem.Models;

public interface IPlanet
{
    public bool CanSustainLife { get; set; }

    public bool CanBeTerraformed { get; set; }

    public bool HasSatelliteMoon { get; set; }
}