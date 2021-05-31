using System;

namespace Solar_System_Project
{
    public class Calculator
    {
        private double gravitationalConstant = 6.67 * Math.Pow(10, -11);
        private double Radius { get; set; }
        private double Mass { get; set; }
        private int DaysInAnYear { get; set; }
        public Calculator(int daysInAnYear)
        {
            this.DaysInAnYear = daysInAnYear;
        }

        public Calculator(double radius)
        {
            this.Radius = radius;
        }
        public Calculator(double radius, double massOfPlanet)
        {
            this.Radius = radius;
            this.Mass = massOfPlanet;
        }
        public double PlanetArea()
        {
            //formula for Planet area
            var result = 4 * Math.PI * (Math.Pow(this.Radius, 2));
            return Math.Round(result, 2);
        }
        public double AsteroidArea()
        {
            //formula for Asteroid area
            var result = (3 * Math.PI * Math.Pow(this.Radius, 2)) / 8;
            return Math.Round(result, 2);
        }
        public double PlanetVelocity()
        {
            //formula for planet velocity
            var result = 4 * Math.PI * Math.Pow(Radius, 3);
            return Math.Round(result, 2);
        }
        private double AccelerationDueToGravity()
        {
            //formula for finding acceleration due to gravity (9.8 on Earth)
            var radiusInMeters = this.Radius * 1000;
            var result = (this.gravitationalConstant * this.Mass) / Math.Pow(radiusInMeters, 2);

            return Math.Round(result, 2);
        }
        private double NewtonToKilograms(double newtons) => newtons / 9.81;

        public double MassOnPlanet(double massOfPerson)
        {
            //finding the acceleration due to gravity
            var accelerationGravity = AccelerationDueToGravity();

            // the result is in Newtons
            var resultInNewtons = Math.Round(massOfPerson * accelerationGravity);

            //converting Newtons to kg
            var resultInKilograms = Math.Round(NewtonToKilograms(resultInNewtons));

            return resultInKilograms;
        }
        public double AgeOnOtherCosmicalObject(int years)
        {
            //calculating how many days a person has lived
            var daysLived = years * 365.26;

            double result = daysLived / this.DaysInAnYear;

            if (result > 1)
                return Math.Round(result);
            else
                return Math.Round(result, 2);

        }


    }
}
