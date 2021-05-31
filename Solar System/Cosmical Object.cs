namespace Solar_System_Project
{
    public abstract class CosmicalObject
    {
        protected double Mass { get; set; }
        public double Radius { get; protected set; }
        public string Name { get; protected set; }
        public int DaysInAnYear { get; protected set; }

        public abstract double Area();

        public abstract string Velocity();

        public abstract string Information();
    }
}
