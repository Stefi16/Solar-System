using Solar_System_Project;
using Solar_System_Project.Solar_System;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solar_System
{
    public partial class Scene : Form
    {
        private List<CosmicalObject> cosmicalObjects = Adder.AllCosmicalObjects();
        private List<Planet> planets = Adder.AllPlanets();
        private List<Ellipse> ellipses = Adder.Ellipses();
        private double TotalArea;
        private List<Asteroid> asteroids = Adder.Asteroids();
        public Scene()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint
                | ControlStyles.OptimizedDoubleBuffer, true);
            PlanetArea();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DrawEllipses();
            MessageBox.Show("Welcome to my Solar System Project. To see the area and velocity of any Asteroid or Planet please click" +
                 " on it (then look at the bottom right corner). Click on the names of the Planets to show more interactions with them. " +
                 "Click on the ellipses to change their color and right click to undo. Enjoy!"); 
           if (File.Exists("ellipses"))
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream str = new FileStream("ellipses", FileMode.Open, FileAccess.Read))
                {
                    ellipses = (List<Ellipse>)formatter.Deserialize(str);
                }
            }
        }
        public void PlanetArea()
        {
            TotalArea = cosmicalObjects
                .Select(x => x.Area())
                .Sum();
            toolStripStatusLabelPlanetArea.Text = $"Total Area: {TotalArea} (six trillion) square km ";
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (var ellipse in ellipses)
            {
                ellipse.Paint(e.Graphics);
            }
        }
        private void DrawEllipses()
        {
            using (Graphics graphics = CreateGraphics())
            {
                foreach (var ellipse in ellipses)
                {
                    ellipse.Paint(graphics);
                }

            }
        }
        private void SolarSytem_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var randomizer = new Random();
                var colors = Adder.Colors();
                foreach (var ellipse in ellipses)
                {
                    var randomNumber = randomizer.Next(0, colors.Count - 1);
                    if (ellipse.ContainsEllipse(e.Location))
                    {
                        ellipse.MyColor = colors.ElementAtOrDefault(randomNumber);
                    }
                }

                Invalidate();
                Application.DoEvents();
            }
            if(e.Button == MouseButtons.Right)
            {
                foreach (var ellipse in ellipses)
                {
                    ellipse.MyColor = Color.DarkBlue;
                }
                Invalidate();
                Application.DoEvents();
            }
            toolStripStatusLabelPlanetArea.Text = $"Total Area: {TotalArea} (six trillion) square km ";
            toolStripStatusLabelVelocity.Text = string.Empty;
        }
        private void pictureBoxSun_Click(object sender, EventArgs e)
        {
            var sun = planets.ElementAt(0);
            var area = sun.Area();
            var velocity = sun.Velocity();
            toolStripStatusLabelPlanetArea.Text = "Area: " + area + " square km";
            toolStripStatusLabelVelocity.Text = "Velocity: " + velocity + " cubic km";
        }

        private void pictureBoxMercury_Click(object sender, EventArgs e)
        {
            var mercury = planets.ElementAt(1);
            var area = mercury.Area();
            var velocity = mercury.Velocity();
            toolStripStatusLabelPlanetArea.Text = "Area: " + area + " square km";
            toolStripStatusLabelVelocity.Text = "Velocity: " + velocity + " cubic km";
        }

        private void pictureBoxVenus_Click(object sender, EventArgs e)
        {
            var venus = planets.ElementAt(2);
            var area = venus.Area();
            var velocity = venus.Velocity();
            toolStripStatusLabelPlanetArea.Text = "Area: " + area + " square km";
            toolStripStatusLabelVelocity.Text = "Velocity: " + velocity + " cubic km";
        }

        private void pictureBoxEarth_Click(object sender, EventArgs e)
        {
            var earth = planets.ElementAt(3);
            var area = earth.Area();
            var velocity = earth.Velocity();
            toolStripStatusLabelPlanetArea.Text = "Area: " + area + " square km";
            toolStripStatusLabelVelocity.Text = "Velocity: " + velocity + " cubic km";
        }

        private void pictureBoxMars_Click(object sender, EventArgs e)
        {
            var mars = planets.ElementAt(4);
            var area = mars.Area();
            var velocity = mars.Velocity();
            toolStripStatusLabelPlanetArea.Text = "Area: " + area + " square km";
            toolStripStatusLabelVelocity.Text = "Velocity: " + velocity + " cubic km";
        }

        private void pictureBoxVesta_Click(object sender, EventArgs e)
        {
            var vesta = asteroids.ElementAt(1);
            var area = vesta.Area();
            var velocity = vesta.Velocity();
            toolStripStatusLabelPlanetArea.Text = "Area: " + area + " square km";
            toolStripStatusLabelVelocity.Text = "Velocity: " + velocity;
        }

        private void pictureBoxCeres_Click(object sender, EventArgs e)
        {
            var ceres = planets.ElementAt(11);
            var area = ceres.Area();
            var velocity = ceres.Velocity();
            toolStripStatusLabelPlanetArea.Text = "Area: " + area + " square km";
            toolStripStatusLabelVelocity.Text = "Velocity: " + velocity + " cubic km";
        }

        private void pictureBoxPallas_Click(object sender, EventArgs e)
        {
            var pallas = asteroids.ElementAt(0);
            var area = pallas.Area();
            var velocity = pallas.Velocity();
            toolStripStatusLabelPlanetArea.Text = "Area: " + area + " square km";
            toolStripStatusLabelVelocity.Text = "Velocity: " + velocity;
        }

        private void pictureBoxJupiter_Click(object sender, EventArgs e)
        {
            var jupiter = planets.ElementAt(5);
            var area = jupiter.Area();
            var velocity = jupiter.Velocity();
            toolStripStatusLabelPlanetArea.Text = "Area: " + area + " square km";
            toolStripStatusLabelVelocity.Text = "Velocity: " + velocity + " cubic km";
        }

        private void pictureBoxSaturn_Click(object sender, EventArgs e)
        {
            var saturn = planets.ElementAt(6);
            var area = saturn.Area();
            var velocity = saturn.Velocity();
            toolStripStatusLabelPlanetArea.Text = "Area: " + area + " square km";
            toolStripStatusLabelVelocity.Text = "Velocity: " + velocity + " cubic km";
        }

        private void pictureBoxUranus_Click(object sender, EventArgs e)
        {
            var uranus = planets.ElementAt(7);
            var area = uranus.Area();
            var velocity = uranus.Velocity();
            toolStripStatusLabelPlanetArea.Text = "Area: " + area + " square km";
            toolStripStatusLabelVelocity.Text = "Velocity: " + velocity + " cubic km";
        }

        private void pictureBoxNeptune_Click(object sender, EventArgs e)
        {
            var neptune = planets.ElementAt(8);
            var area = neptune.Area();
            var velocity = neptune.Velocity();
            toolStripStatusLabelPlanetArea.Text = "Area: " + area + " square km";
            toolStripStatusLabelVelocity.Text = "Velocity: " + velocity + " cubic km";
        }

        private void pictureBoxEris_Click(object sender, EventArgs e)
        {
            var eris = planets.ElementAt(10);
            var area = eris.Area();
            var velocity = eris.Velocity();
            toolStripStatusLabelPlanetArea.Text = "Area: " + area + " square km";
            toolStripStatusLabelVelocity.Text = "Velocity: " + velocity + " cubic km";
        }

        private void pictureBoxPluto_Click(object sender, EventArgs e)
        {
            var pluto = planets.ElementAt(9);
            var area = pluto.Area();
            var velocity = pluto.Velocity();
            toolStripStatusLabelPlanetArea.Text = "Area: " + area + " square km";
            toolStripStatusLabelVelocity.Text = "Velocity: " + velocity + " cubic km";
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelPlanetArea.Text = $"Total Area: {TotalArea} (six trillion) square km ";
            toolStripStatusLabelVelocity.Text = string.Empty;
        }

        private void howOldWillIBeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sun = planets.ElementAt(0);
            MessageBox.Show(sun.AgeOnAnotherPlanet(V.Age));
        }

        private void howMuchWillIWeighToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            var weight = new InputWeight();
            weight.ShowDialog();
            if (V.Weight == default)
                MessageBox.Show("Please enter your weight!");
            else
            {
                var sun = new Sun();
                MessageBox.Show("On the Sun you will weigh: " + sun.WeightOnPlanet(V.Weight) + " kg.");
            }
        }

        private void whatShouldIWearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sun = planets.ElementAt(0);
            MessageBox.Show(sun.WhatToWear());
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sun = planets.ElementAt(0);
            MessageBox.Show(sun.Information());
        }

        private void buttonCosmicalObjectsStatistics_Click(object sender, EventArgs e)
        {
            var t = new AdditionalInformation();
            t.ShowDialog();
        }

        private void toolStripMenuItemMercuryAge_Click(object sender, EventArgs e)
        {
            var age = new InputAge();
            age.ShowDialog();
            if (V.Age == default)
                MessageBox.Show("Please enter your age first.");
            else
            {
                var merc = new Mercury();
                MessageBox.Show("If you lived on Mercury you will be: " + merc.AgeOnAnotherPlanet(V.Age) + " years old.");
            }
        }
        
        private void toolStripMenuItemMercuryWeight_Click(object sender, EventArgs e)
        {
            var weight = new InputWeight();
            weight.ShowDialog();
            if (V.Weight == default)
                MessageBox.Show("Please enter your weight first.");
            else
            {
                var merc = new Mercury();
                MessageBox.Show("On Mercury you will weigh: " + merc.WeightOnPlanet(V.Weight) + " kg.");
            }
        }
        private void toolStripMenuItemMercuryClothes_Click(object sender, EventArgs e)
        {
            var merc = planets.ElementAt(1);
            MessageBox.Show(merc.WhatToWear());
        }
        private void toolStripMenuItemMercuryInfo_Click(object sender, EventArgs e)
        {
            var merc = planets.ElementAt(1);
            MessageBox.Show(merc.Information());
        }

        private void toolStripMenuItemVenusAge_Click(object sender, EventArgs e)
        {
            var age = new InputAge();
            age.ShowDialog();
            if (V.Age == default)
                MessageBox.Show("Please enter your age first.");
            else
            {
                var venus = new Venus();
                MessageBox.Show("If you lived on Venus you will be: " + venus.AgeOnAnotherPlanet(V.Age) + " years old.");
            }
        }

        private void toolStripMenuItemVenusWeight_Click(object sender, EventArgs e)
        {
            var weight = new InputWeight();
            weight.ShowDialog();
            if (V.Weight == default)
                MessageBox.Show("Please enter your weight first.");
            else
            {
                var venus = new Venus();
                MessageBox.Show("On Venus you will weigh: " + venus.WeightOnPlanet(V.Weight) + " kg.");
            }
        }

        private void toolStripMenuItemVenusClothes_Click(object sender, EventArgs e)
        {
            var venus = planets.ElementAt(2);
            MessageBox.Show(venus.WhatToWear());
        }

        private void toolStripMenuItemVenusInfo_Click(object sender, EventArgs e)
        {
            var venus = planets.ElementAt(2);
            MessageBox.Show(venus.Information());
        }

        private void toolStripMenuItemEarthAge_Click(object sender, EventArgs e)
        {
            var age = new InputAge();
            age.ShowDialog();
            if (V.Age == default)
                MessageBox.Show("Please enter your age first.");
            else
            {
                var earth = new Earth();
                MessageBox.Show(earth.AgeOnAnotherPlanet(V.Age));
            }
        }

        private void toolStripMenuItemEarthWeigh_Click(object sender, EventArgs e)
        {
            var weight = new InputWeight();
            weight.ShowDialog();
            if (V.Weight == default)
                MessageBox.Show("Please enter your weight first.");
            else
            {
                var earth = new Earth();
                MessageBox.Show(earth.WeightOnPlanet(V.Weight));
            }
        }

        private void toolStripMenuItemEarthClothes_Click(object sender, EventArgs e)
        {
            var earth = planets.ElementAt(3);
            MessageBox.Show(earth.WhatToWear());
        }

        private void toolStripMenuItemEarthInfo_Click(object sender, EventArgs e)
        {
            var earth = planets.ElementAt(3);
            MessageBox.Show(earth.Information());
        }

        private void toolStripMenuItemAgeOnMars_Click(object sender, EventArgs e)
        {
            var age = new InputAge();
            age.ShowDialog();
            if (V.Age == default)
                MessageBox.Show("Please enter your age first.");
            else
            {
                var mars = new Mars();
                MessageBox.Show("If you lived on Mars you will be: " + mars.AgeOnAnotherPlanet(V.Age) + " years old.");
            }
        }

        private void toolStripMenuItemMarsWeight_Click(object sender, EventArgs e)
        {
            var weight = new InputWeight();
            weight.ShowDialog();
            if (V.Weight == default)
                MessageBox.Show("Please enter your weight first.");
            else
            {
                var mars = new Mars();
                MessageBox.Show("On Mars you will weigh: " + mars.WeightOnPlanet(V.Weight) + " kg.");
            }
        }

        private void toolStripMenuItemMarsClothes_Click(object sender, EventArgs e)
        {
            var mars = planets.ElementAt(4);
            MessageBox.Show(mars.WhatToWear());
        }

        private void toolStripMenuItemMarsInfo_Click(object sender, EventArgs e)
        {
            var mars = planets.ElementAt(4);
            MessageBox.Show(mars.Information());
        }

        private void toolStripMenuItemCeresAge_Click(object sender, EventArgs e)
        {
            var age = new InputAge();
            age.ShowDialog();
            if (V.Age == default)
                MessageBox.Show("Please enter your age first.");
            else
            {
                var ceres = new Ceres();
                MessageBox.Show("If you lived on Ceres you will be: " + ceres.AgeOnAnotherPlanet(V.Age) + " years old.");
            }
        }

        private void toolStripMenuItemCeresWeight_Click(object sender, EventArgs e)
        {
            var weight = new InputWeight();
            weight.ShowDialog();
            if (V.Weight == default)
                MessageBox.Show("Please enter your weight first.");
            else
            {
                var ceres = new Ceres();
                MessageBox.Show("On Ceres you will weigh: " + ceres.WeightOnPlanet(V.Weight) + " kg.");
            }
        }

        private void toolStripMenuItemCeresClothes_Click(object sender, EventArgs e)
        {
            var ceres = planets.ElementAt(11);
            MessageBox.Show(ceres.WhatToWear());
        }

        private void toolStripMenuItemCeresInfo_Click(object sender, EventArgs e)
        {
            var ceres = planets.ElementAt(11);
            MessageBox.Show(ceres.Information());
        }

        private void toolStripMenuItemJupiterAge_Click(object sender, EventArgs e)
        {
            var age = new InputAge();
            age.ShowDialog();
            if (V.Age == default)
                MessageBox.Show("Please enter your age first.");
            else
            {
                var jupiter = new Jupiter();
                MessageBox.Show("If you lived on Jupiter you will be: " + jupiter.AgeOnAnotherPlanet(V.Age) + " years old.");
            }
        }

        private void toolStripMenuItemJupiterWeigh_Click(object sender, EventArgs e)
        {
            var weight = new InputWeight();
            weight.ShowDialog();
            if (V.Weight == default)
                MessageBox.Show("Please enter your weight first.");
            else
            {
                var jupiter = new Jupiter();
                MessageBox.Show("On Jupiter you will weigh: " + jupiter.WeightOnPlanet(V.Weight) + " kg.");
            }
        }

        private void toolStripMenuItemJupiterClothes_Click(object sender, EventArgs e)
        {
            var jupiter = planets.ElementAt(5);
            MessageBox.Show(jupiter.WhatToWear());
        }

        private void toolStripMenuItemJupiterInfo_Click(object sender, EventArgs e)
        {
            var jupiter = planets.ElementAt(5);
            MessageBox.Show(jupiter.Information());
        }

        private void toolStripMenuItemSaturnAge_Click(object sender, EventArgs e)
        {
            var age = new InputAge();
            age.ShowDialog();
            if (V.Age == default)
                MessageBox.Show("Please enter your age first.");
            else
            {
                var saturn = new Saturn();
                MessageBox.Show("If you lived on Saturn you will be: " + saturn.AgeOnAnotherPlanet(V.Age) + " years old.");
            }
        }

        private void toolStripMenuItemSaturnWeight_Click(object sender, EventArgs e)
        {
            var weight = new InputWeight();
            weight.ShowDialog();
            if (V.Weight == default)
                MessageBox.Show("Please enter your weight first.");
            else
            {
                var saturn = new Saturn();
                MessageBox.Show("On Saturn you will weigh: " + saturn.WeightOnPlanet(V.Weight) + " kg.");
            }
        }

        private void toolStripMenuItemSaturnWhatToWear_Click(object sender, EventArgs e)
        {
            var saturn = planets.ElementAt(6);
            MessageBox.Show(saturn.WhatToWear());
        }

        private void toolStripMenuItemSaturnInfo_Click(object sender, EventArgs e)
        {
            var saturn = planets.ElementAt(6);
            MessageBox.Show(saturn.Information());
        }

        private void toolStripMenuItemUranusAge_Click(object sender, EventArgs e)
        {
            var age = new InputAge();
            age.ShowDialog();
            if (V.Age == default)
                MessageBox.Show("Please enter your age first.");
            else
            {
                var uranus = new Uranus();
                MessageBox.Show("If you lived on Uranus you will be: " + uranus.AgeOnAnotherPlanet(V.Age) + " years old.");
            }
        }

        private void toolStripMenuItemUranusWeight_Click(object sender, EventArgs e)
        {
            var weight = new InputWeight();
            weight.ShowDialog();
            if (V.Weight == default)
                MessageBox.Show("Please enter your weight first.");
            else
            {
                var uranus = new Uranus();
                MessageBox.Show("On Uranus you will weigh: " + uranus.WeightOnPlanet(V.Weight) + " kg.");
            }
        }

        private void toolStripMenuItemUranusClothes_Click(object sender, EventArgs e)
        {
            var uranus = planets.ElementAt(7);
            MessageBox.Show(uranus.WhatToWear());
        }

        private void toolStripMenuItemUranusInfo_Click(object sender, EventArgs e)
        {
            var uranus = planets.ElementAt(7);
            MessageBox.Show(uranus.Information());
        }

        private void toolStripMenuItemNeptuneAge_Click(object sender, EventArgs e)
        {
            var age = new InputAge();
            age.ShowDialog();
            if (V.Age == default)
                MessageBox.Show("Please enter your age first.");
            else
            {
                var neptune = new Neptune();
                MessageBox.Show("If you lived on Neptune you will be: " + neptune.AgeOnAnotherPlanet(V.Age) + " years old.");
            }
        }

        private void toolStripMenuItemNeptuneWeight_Click(object sender, EventArgs e)
        {
            var weight = new InputWeight();
            weight.ShowDialog();
            if (V.Weight == default)
                MessageBox.Show("Please enter your weight first.");
            else
            {
                var neptune = new Neptune();
                MessageBox.Show("On Neptune you will weigh: " + neptune.WeightOnPlanet(V.Weight) + " kg.");
            }
        }

        private void toolStripMenuItemNeptuneClothes_Click(object sender, EventArgs e)
        {
            var neptune = planets.ElementAt(8);
            MessageBox.Show(neptune.WhatToWear());
        }

        private void toolStripMenuItemNeptuneInfo_Click(object sender, EventArgs e)
        {
            var neptune = planets.ElementAt(8);
            MessageBox.Show(neptune.Information());
        }

        private void toolStripMenuItemPlutoAge_Click(object sender, EventArgs e)
        {
            var age = new InputAge();
            age.ShowDialog();
            if (V.Age == default)
                MessageBox.Show("Please enter your age first.");
            else
            {
                var pluto = new Pluto();
                MessageBox.Show("If you lived on Pluto you will be: " + pluto.AgeOnAnotherPlanet(V.Age) + " years old.");
            }
        }

        private void toolStripMenuItemPlutoWeight_Click(object sender, EventArgs e)
        {
            var weight = new InputWeight();
            weight.ShowDialog();
            if (V.Weight == default)
                MessageBox.Show("Please enter your weight first.");
            else
            {
                var pluto = new Pluto();
                MessageBox.Show("On Pluto you will weigh: " + pluto.WeightOnPlanet(V.Weight) + " kg.");
            }
        }

        private void toolStripMenuItemPlutoClothes_Click(object sender, EventArgs e)
        {
            var pluto = planets.ElementAt(9);
            MessageBox.Show(pluto.WhatToWear());
        }

        private void toolStripMenuItemPlutoInfo_Click(object sender, EventArgs e)
        {
            var pluto = planets.ElementAt(9);
            MessageBox.Show(pluto.Information());
        }

        private void toolStripMenuItemErisAge_Click(object sender, EventArgs e)
        {
            var age = new InputAge();
            age.ShowDialog();
            if (V.Age == default)
                MessageBox.Show("Please enter your age first.");
            else
            {
                var eris = new Eris();
                MessageBox.Show("If you lived on Eris you will be: " + eris.AgeOnAnotherPlanet(V.Age) + " years old.");
            }
        }

        private void toolStripMenuItemErisWeight_Click(object sender, EventArgs e)
        {
            
            var weight = new InputWeight();
            weight.ShowDialog();
            if (V.Weight == default)
                MessageBox.Show("Please enter your weight first.");
            else
            {
                var eris = new Eris();
                MessageBox.Show("On Eris you will weigh: " + eris.WeightOnPlanet(V.Weight) + " kg.");
            }
        }

        private void toolStripMenuItemErisClothes_Click(object sender, EventArgs e)
        {
            var eris = planets.ElementAt(10);
            MessageBox.Show(eris.WhatToWear());
        }

        private void toolStripMenuItemErisInfo_Click(object sender, EventArgs e)
        {
            var eris = planets.ElementAt(10);
            MessageBox.Show(eris.Information());
        }

        private void toolStripMenuItemPallasAge_Click(object sender, EventArgs e)
        {
            var age = new InputAge();
            age.ShowDialog();
            if (V.Age == default)
                MessageBox.Show("Please enter your age first.");
            else
            {
                var pallas = new Pallas();
                MessageBox.Show("If you lived on Pallas you will be: " + pallas.AgeOnAsteroid(V.Age) + " years old.");
            }
        }

        private void toolStripMenuItemPallasInfo_Click(object sender, EventArgs e)
        {
            var pallas = planets.ElementAt(13);
            MessageBox.Show(pallas.Information());
        }

        private void toolStripMenuItemVestaAge_Click(object sender, EventArgs e)
        {
            var age = new InputAge();
            age.ShowDialog();
            if (V.Age == default)
                MessageBox.Show("Please enter your age first.");
            else
            {
                var vesta = new Vesta();
                MessageBox.Show("If you lived on Vesta you will be: " + vesta.AgeOnAsteroid(V.Age) + " years old.");
            }
        }

        private void toolStripMenuItemVestaInfo_Click(object sender, EventArgs e)
        {
            var vesta = planets.ElementAt(12);
            MessageBox.Show(vesta.Information());
        }

        private void Scene_FormClosing(object sender, FormClosingEventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            using (Stream str = new FileStream("ellipses", FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(str, ellipses);
            }
        }
    }

}
