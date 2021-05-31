using Solar_System_Project;
using Solar_System_Project.Solar_System;
using System.Collections.Generic;
using System.Drawing;

namespace Solar_System
{
    class Adder
    {
        public static List<CosmicalObject> AllCosmicalObjects()
        {
            var lissy = new List<CosmicalObject>();

            lissy.Add(new Sun());
            lissy.Add(new Mercury());
            lissy.Add(new Venus());
            lissy.Add(new Earth());
            lissy.Add(new Mars());
            lissy.Add(new Jupiter());
            lissy.Add(new Saturn());
            lissy.Add(new Uranus());
            lissy.Add(new Neptune());
            lissy.Add(new Pluto());
            lissy.Add(new Eris());
            lissy.Add(new Ceres());
            lissy.Add(new Vesta());
            lissy.Add(new Pallas());

            return lissy;
        }
        public static List<Planet> AllPlanets()
        {
            var lissy = new List<Planet>();

            lissy.Add(new Sun());
            lissy.Add(new Mercury());
            lissy.Add(new Venus());
            lissy.Add(new Earth());
            lissy.Add(new Mars());
            lissy.Add(new Jupiter());
            lissy.Add(new Saturn());
            lissy.Add(new Uranus());
            lissy.Add(new Neptune());
            lissy.Add(new Pluto());
            lissy.Add(new Eris());
            lissy.Add(new Ceres());


            return lissy;
        }
        public static List<Planet> DwarfPlanets()
        {
            var lissy = new List<Planet>();

            lissy.Add(new Pluto());
            lissy.Add(new Eris());
            lissy.Add(new Ceres());

            return lissy;
        }
        public static List<Asteroid> Asteroids()
        {
            var asteroids = new List<Asteroid>();

            asteroids.Add(new Pallas());
            asteroids.Add(new Vesta());

            return asteroids;
        }

        public static List<Ellipse> Ellipses()
        {
            var ellipses = new List<Ellipse>();

            var ell = new Ellipse(new Point(377, 221), 325, 200);
            ell.MyColor = Color.DarkBlue;
            ellipses.Add(ell);
            var ell1 = new Ellipse(new Point(325, 179), 425, 300);
            ell1.MyColor = Color.DarkBlue;
            ellipses.Add(ell1);
            var ell2 = new Ellipse(new Point(275, 140), 525, 400);
            ell2.MyColor = Color.DarkBlue;
            ellipses.Add(ell2);
            var ell3 = new Ellipse(new Point(225, 90), 625, 500);
            ell3.MyColor = Color.DarkBlue;
            ellipses.Add(ell3);
            var ell4 = new Ellipse(new Point(175, 45), 725, 600);
            ell4.MyColor = Color.DarkBlue;
            ellipses.Add(ell4);
            var ell5 = new Ellipse(new Point(110, 10), 860, 675);
            ell5.MyColor = Color.DarkBlue;
            ellipses.Add(ell5);

            return ellipses;
        }
        public static List<Rectangle> SquareAdder()
        {
            var squares = new List<Rectangle>();

            var sq1 = new Rectangle(Color.DarkOrange, new Point(2, 2), 50, 50);
            sq1.OriginalPosition = new Point(2, 2);
            squares.Add(sq1);

            var sq2 = new Rectangle(Color.DarkOrange, new Point(2, 221), 50, 50);
            sq2.OriginalPosition = new Point(2, 221);
            squares.Add(sq2);

            var sq3 = new Rectangle(Color.DarkOrange, new Point(365, 2), 50, 50);
            sq3.OriginalPosition = new Point(365, 2);
            squares.Add(sq3);

            var sq4 = new Rectangle(Color.DarkOrange, new Point(365, 221), 50, 50);
            sq4.OriginalPosition = new Point(365, 221);
            squares.Add(sq4);

            return squares;
        }
        public static List<Rectangle> RectangleAdder() 
        {
            var rectangles = new List<Rectangle>();

            var rect = new Rectangle(Color.Red, new Point(2, 2), 50, 30);
            rect.OriginalPosition = new Point(2, 2);
            rectangles.Add(rect);

            var rect2 = new Rectangle(Color.Red, new Point(365, 2), 50, 30);
            rect2.OriginalPosition = new Point(365, 2);
            rectangles.Add(rect2);

            var rect3 = new Rectangle(Color.Red, new Point(335, 221), 80, 50);
            rect3.OriginalPosition = new Point(335, 221);
            rectangles.Add(rect3);

            var rect4 = new Rectangle(Color.Red, new Point(2, 221), 80, 50);
            rect4.OriginalPosition = new Point(2, 221);
            rectangles.Add(rect4);

            var rect5 = new Rectangle(Color.Red, new Point(154, 191), 100, 80);
            rect5.OriginalPosition = new Point(154, 191);
            rectangles.Add(rect5);

            return rectangles;
        }
        public static List<Color> Colors()
        {
            var colors = new List<Color>();

            colors.Add(Color.Turquoise);
            colors.Add(Color.Yellow);
            colors.Add(Color.DarkViolet);
            colors.Add(Color.MistyRose);
            colors.Add(Color.DarkRed);
            colors.Add(Color.DeepPink);
            colors.Add(Color.DarkOliveGreen);
            colors.Add(Color.DarkOrchid);
            colors.Add(Color.DodgerBlue);
            colors.Add(Color.DarkKhaki);
            colors.Add(Color.HotPink);
            colors.Add(Color.BlueViolet);
            colors.Add(Color.Lavender);
            colors.Add(Color.LemonChiffon);
            colors.Add(Color.AliceBlue);
            colors.Add(Color.LightSeaGreen);
            colors.Add(Color.DarkGray);

            return colors;
        }
    }
}
