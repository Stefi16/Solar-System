using System;

namespace Solar_System_Project
{
    public class Jupiter : Planet
    {
        public Jupiter()
        {
            this.Radius = 69911;
            this.Mass = 1.898 * Math.Pow(10, 27);
            this.DaysInAnYear = 4333;
            this.Temperature = -145;
            IsDwarf = false;
            this.Name = "Jupiter";
        }
        public override string Information()
        {
            return "Jupiter is the fifth planet from the Sun and the largest in the Solar System. " +
                "Jupiter is one of the brightest objects visible to the naked eye in the night sky," +
                " and has been known to ancient civilizations since before recorded history.";
        }

    }
}
