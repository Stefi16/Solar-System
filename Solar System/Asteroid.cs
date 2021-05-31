using System;

namespace Solar_System_Project
{
    public class Asteroid : CosmicalObject
    {
        public Asteroid()
        {

        }
        public override double Area()
        {
            var calculator = new Calculator(this.Radius);
            var result = calculator.AsteroidArea();

            return result;
        }

        public override string Velocity()
        {
            return "Due to constant movement and its irregular shape, finding the velocity " +
                "of an Asteroid is nearly impossible.";
        }
        public override string Information()
        {
            return "Asteroids are minor planets, especially of the inner Solar System." +
                " They are mostly composed of minerals and rocks, have a diameter larger than one meter " +
                "and form closer to the Sun (preventing the development of ice).";
        }
        public virtual string AgeOnAsteroid(int age)
        {
            if (this.DaysInAnYear == default)
                throw new ArgumentOutOfRangeException("You must choose a concrete Asteroid first");
            if (age > 0)
            {
                var calculator = new Calculator(this.DaysInAnYear);
                var result = calculator.AgeOnOtherCosmicalObject(age);

                return result.ToString();
            }
            else
                throw new ArgumentOutOfRangeException("Age must be a positive nuber higher than 0");
        }

    }
}
