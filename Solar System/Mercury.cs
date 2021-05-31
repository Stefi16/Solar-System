using System;

namespace Solar_System_Project
{
    public class Mercury : Planet
    {

        public Mercury()
        {
            this.Radius = 2439.7;
            this.Mass = 3.285 * Math.Pow(10, 23);
            this.DaysInAnYear = 88;
            this.Temperature = 167;
            IsDwarf = false;
            this.Name = "Mercury";
        }
       
        public override string Information()
        {
            return "Mercury is the smallest and innermost planet in the Solar System."
                + " It is named after the Roman deity Mercury, the messenger of the gods.";
        }

    }
}
