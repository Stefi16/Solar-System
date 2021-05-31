using System;

namespace Solar_System_Project
{
    public class Uranus : Planet
    {
        public Uranus()
        {
            this.Radius = 25362;
            this.Mass = 8.681 * Math.Pow(10, 25);
            this.DaysInAnYear = 30687;
            this.Temperature = -224;
            IsDwarf = false;
            this.Name = "Uranus";
        }
        public override string Information()
        {
            return "Uranus is the seventh planet from the Sun. Uranus is similar in composition to Neptune, " +
                "and both have bulk chemical compositions which differ from that of the larger gas giants Jupiter and Saturn.";
        }

    }
}
