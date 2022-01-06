using AIHR.SolarSystem.Models;

// Stars
var sun = new Star("Sun", "sun.png", 0, 0, 1.9891e30);

// Gas Giants
var jupiter = new GasGiant("Jupiter", "jupiter.png", 778600000, 4331, 1.898e27);
var saturn = new GasGiant("Saturn", "saturn.png", 1433500000, 10747, 5.68e26);

// Ice Giants
var uranos = new IceGiants("Uranos", "uranos.png", 2872500000, 30589, 8.68e25);
var neptune = new IceGiants("Neptune", "neptune.png", 4495100000, 59800, 1.02e26);

// Terrestrial Planets
var mercury = new TerrestrialPlanet("Mercury", "mercury.png", 57900000, 88, 0.330e24);
var venus = new TerrestrialPlanet("Venus", "venus.png", 108200000, 224, 4.87e24);
var earth = new TerrestrialPlanet("Earth", "earth.png", 149600000, 365, 5.97e24);
var mars = new TerrestrialPlanet("Mars", "mars.png", 227900000, 687, 0.642e24);

// Dwarf Planets
var ceres = new DwarfPlanet("Ceres", "ceres.png", 413000000, 1682, 9.1e20);
var pluto = new DwarfPlanet("Pluto", "pluto.png", 5900000000, 90560, 0.0130e24);
var eris = new DwarfPlanet("Eris", "eris.png", 10125000000, 204035, 1.672e22);
var haumea = new DwarfPlanet("Haumea", "haumea.png", 6452000000, 104192, 4.006e21);
var makemake = new DwarfPlanet("Makemake", "makemake.png", 847000000, 111690, 3.1e21);

// Create a collection for all 14 celestial bodies where we can retrieve its name, a picture, distance from the sun, orbital period, and mass.
var solarSystem = new SolarSystem();
solarSystem.Members.AddRange(new List<CelestialBody>(){sun,jupiter,saturn,uranos,neptune,mercury,venus,earth,mars,ceres,pluto,eris,haumea,makemake});


//  Use Lambda Expressions to select all celestial bodies sorted by orbital period around the sun (in days) from shortest to the longest.
var res = solarSystem.Members.Select(p => p).OrderBy(p=>p.OrbitalPeriod);
int id = 0;
foreach (var p in res)
{
    id += 1;
    Console.WriteLine($"{id}- Name: {p.Name}, Distance from Sun: {p.DistanceFromSun}, Orbital period: {p.OrbitalPeriod} days, Mass: {p.Mass}Kg!");
    Console.WriteLine($"   # {p.Colonize()}");
    Console.WriteLine("----------------");
}
