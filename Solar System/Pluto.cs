using System;

namespace Solar_System_Project.Solar_System
{
    public class Pluto : Planet
    {
       
        public Pluto()
        {
            this.Radius = 1188.3;
            this.Mass = 1.30900 * Math.Pow(10, 22);
            this.DaysInAnYear = 90600;
            this.Temperature = -225;
            IsDwarf = true;
            this.Name = "Pluto";
        }
        
        public override string Information()
        {
            return "Pluto is an icy dwarf planet in the Kuiper belt (a ring of bodies beyond the orbit of Neptune). " +
                "It was the first and the largest Kuiper belt object to be discovered.";
        }
    }
}
