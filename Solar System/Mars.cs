using System;

namespace Solar_System_Project
{
    public class Mars : Planet
    {
        public Mars()
        {
            this.Radius = 3389.5;
            this.Mass = 6.39 * Math.Pow(10, 23);
            this.DaysInAnYear = 687;
            this.Temperature = -55;
            IsDwarf = false;
            this.Name = "Mars";
        }
        
        public override string Information()
        {
            return "Mars is the fourth planet from the Sun and the second-smallest planet in the Solar System after Mercury." +
                " It is reffered to as \"The Red Planet\", due to its reddish appearance" +
                " distinctive among the astronomical bodies visible to the naked eye ";
        }

    }
}
