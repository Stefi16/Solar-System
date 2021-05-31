using System;

namespace Solar_System_Project.Solar_System
{
    class Eris : Planet
    {
        public Eris()
        {
            this.Radius = 1163;
            this.Mass = 1.66 * Math.Pow(10, 22);
            this.DaysInAnYear = 204000;
            this.Temperature = -231;
            IsDwarf = true;
            this.Name = "Eris";
        }
        public override string Information()
        {
            return "Eris is the most massive and second-largest known dwarf planet in the Solar System. " +
                "It is also known for being the ninth-most massive object directly orbiting the Sun. " +
                "Eris is also the largest object that has not been visited by a spacecraft.";
        }
    }
}
