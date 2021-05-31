using System;

namespace Solar_System_Project
{
    public class Neptune : Planet
    {
        public Neptune()
        {
            this.Radius = 24622;
            this.Mass = 1.024 * Math.Pow(10, 26);
            this.DaysInAnYear = 60190;
            this.Temperature = -218;
            IsDwarf = false;
            this.Name = "Neptune";
        }
        
        public override string Information()
        {
            return "Neptune is the eighth and farthest known planet from the Sun in the Solar System." +
                " Neptune is 17 times the mass of Earth, slightly more massive than its near-twin Uranus. " +
                "Neptune is denser and physically smaller than Uranus because its greater mass causes" +
                " more gravitational compression of its atmosphere.";
        }

    }
}
