using System;

namespace Solar_System_Project
{
    public class Venus : Planet
    {
        public Venus()
        {
            this.Radius = 6051.8;
            this.Mass = 4.867 * Math.Pow(10, 24);
            this.DaysInAnYear = 225;
            this.Temperature = 453;
            IsDwarf = false;
            this.Name = "Venus";
        }
        
        public override string Information()
        {
            return "Venus is the second planet from the Sun." +
                " As the second-brightest natural object in the night sky after the Moon," +
                " Venus can cast shadows and, rarely, is visible to the naked eye in broad daylight.";
        }

    }
}
