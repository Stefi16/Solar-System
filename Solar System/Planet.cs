using System;

namespace Solar_System_Project
{
    public class Planet : CosmicalObject
    {
        public bool IsDwarf { get; protected set; }
        public int Temperature { get; protected set; }
        public Planet()
        {

        }
        public override double Area()
        {
            var calculator = new Calculator(this.Radius);
            var result = calculator.PlanetArea();

            return result;
        }

        public override string Velocity()
        {
            var calculator = new Calculator(this.Radius);
            var result = calculator.PlanetVelocity();

            return result.ToString();
        }
        public override string Information()
        {
            return "A planet is an astronomical body orbiting a star or stellar remnant that is massive enough " +
                "to be rounded by its own gravity, but not massive enough to cause thermonuclear fusion";
        }
        public virtual string WeightOnPlanet(double mass)
        {
            // calculating the mass of the person on the selected planet
            if (mass >= 1)
            {
                var calculator = new Calculator(this.Radius, this.Mass);
                var result = calculator.MassOnPlanet(mass);
                return result.ToString();
            }
            else
                throw new ArgumentOutOfRangeException("Please enter mass greater than 0 kg.");
            
        }
        public virtual string AgeOnAnotherPlanet(int age)
        {
            if (this.DaysInAnYear == default)
                throw new ArgumentOutOfRangeException("You must choose a concrete Planet first");
            if (age > 0)
            {
                var calculator = new Calculator(this.DaysInAnYear);
                var result = calculator.AgeOnOtherCosmicalObject(age);

                return result.ToString();
            }
            else
                throw new ArgumentOutOfRangeException("Age must be a positive number higher than 0");
        }
        public string WhatToWear()
        {
            if (this.Temperature > 1000)
                return "Given you are immuned to boiling you will be fine wearing a swimsuit.";
            if (this.Temperature < 1000 && this.Temperature >= 100)
                return "If you love to be hot and you are immuned to the heat this planet is for you! Try wearing a t-shirt and shorts.";
            if (this.Temperature == 17)
                return "Sorry I'm not a stylist to tell you what to wear on Earth.";
            if (this.Temperature < 0 && this.Temperature > -200)
                return "You might feel a slight freezing effect here. However if you can withstand the negative temperatures you might enjoy it." +
                    " Nonetheless you might want to wear a couple of sweaters, tights, sweatpants and just in case a winter jacket.";
            if (this.Temperature < -200 && this.Temperature != -231)
                return "If you are immuned to cold and want to visit these lovely places please put on a lot of layers " +
                    "of winter clothes(jackets, sweaters, etc.) and to top it all off bring your grandmother's blanket.";
            if (this.Temperature == -231)
                return "This is the coldest place we have on our list. If you still want to visit and don't know what to wear I can answer you. " +
                    "Put on so many clothes that it becomes hard to walk but easy to roll around (just like a ball).";
            return "Please choose a Planet first.";
        }
    }
}
