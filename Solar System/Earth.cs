namespace Solar_System_Project
{
    public class Earth : Planet
    {
        public Earth() : base()
        {
            this.DaysInAnYear = 365;
            this.Radius = 6371;
            this.Temperature = 17;
            IsDwarf = false;
            this.Name = "Earth";
        }
       
        public override string Information()
        {
            return "Earth is the third planet from the Sun and the only astronomical object known to harbor life." +
                " According to radiometric dating and other evidence, Earth formed over 4.5 billion years ago.";
        }
        public override string AgeOnAnotherPlanet(int age)
        {
            return "Unsurplrisingly your age on Earth is the same" +
                " as the age you entered: " + age + ".";
        }
        public override string WeightOnPlanet(double mass)
        {
            return $"Well, your weight is the same as you entered ({mass} kg) " +
                "only you can change that number, at least on Earth.";
        }
    }
}
