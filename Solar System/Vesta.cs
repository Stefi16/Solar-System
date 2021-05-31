namespace Solar_System_Project
{
    public class Vesta : Asteroid
    {
        public Vesta()
        {
            this.Radius = 262.7;
            this.DaysInAnYear = 1325;
            this.Name = "Vesta";
        }
        public override string Information()
        {
            return "Vesta is one of the largest objects in the asteroid belt. " +
                "Vesta is probably the third-largest asteroid, after Pallas, and contributes" +
                " an estimated 9% of the mass of the asteroid belt.";
        }
    }
}
