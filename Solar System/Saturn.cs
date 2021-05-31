using System;

namespace Solar_System_Project
{
    public class Saturn : Planet
    {
        public Saturn()
        {
            this.Radius = 58232;
            this.Mass = 5.683 * Math.Pow(10, 26);
            this.DaysInAnYear = 10756;
            this.Temperature = -178;
            IsDwarf = false;
            this.Name = "Saturn";
        }
        public override string Information()
        {
            return "Saturn is the sixth planet from the Sun and the second-largest in the Solar System." +
                " It only has one-eighth the average density of Earth. However, with its larger volume," +
                " Saturn is over 95 times more massive.";
        }

    }
}
