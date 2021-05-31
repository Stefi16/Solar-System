namespace Solar_System_Project
{
    public class Pallas : Asteroid
    {
        public Pallas()
        {
            this.Radius = 272.5;
            this.DaysInAnYear = 1690;
            this.Name = "Pallas";
        }

        public override string Information()
        {
            return "Pallas is the second asteroid to have been discovered." +
                " It is one of the largest asteroids in the Solar System. " +
                "Pallas's surface is most likely composed of a silicate(silicone and oxygen) material;";
        }
    }
}
