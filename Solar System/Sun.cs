using System;

namespace Solar_System_Project
{
    public class Sun : Planet
    {
        public Sun()
        {
            this.Radius = 696342;
            this.Mass = 1.989 * Math.Pow(10, 30);
            this.Temperature = 5505;
            IsDwarf = false;
            this.Name = "Sun";
        }
        
        public override string Information()
        {
            return "The Sun is the star at the center of the Solar System. It is a nearly perfect sphere of hot plasma."
                + " It is by far the most important source of energy for life on Earth.";
        }
        public override string AgeOnAnotherPlanet(int age)
        {
            return "The concept of \"a year\" has no meaning for the Sun. " +
                "However the Sun orbits the Milky Way but it takes 225 - 250 million years to make one full orbit.";
        }


    }
}
