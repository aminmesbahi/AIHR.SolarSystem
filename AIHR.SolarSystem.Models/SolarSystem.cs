using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIHR.SolarSystem.Models
{
    public class SolarSystem
    {
        public SolarSystem()
        {
            Members = new List<CelestialBody>();
        }
        public List<CelestialBody> Members { get; set; }
        public int MembersCount => Members.Count;
    }
}
