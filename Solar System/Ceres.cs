using System;

namespace Solar_System_Project.Solar_System
{
    class Ceres : Planet
    {
        public Ceres()
        {
            this.Radius = 476;
            this.Mass = 8.958 * Math.Pow(10, 20);
            this.DaysInAnYear = 1682;
            this.Temperature = -38;
            IsDwarf = true;
            this.Name = "Ceres";
        }
        public override string Information()
        {
            return "Ceres is the largest object in the main asteroid belt" +
                " that lies between the orbits of Mars and Jupiter. " +
                "It is both the largest of the asteroids and the only unambiguous " +
                "dwarf planet currently inside Neptune's orbit.";
        }
    }
}
