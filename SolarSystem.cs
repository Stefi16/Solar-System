using Solar_System_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solar_System_OOP
{
    public partial class SolarSystem : Form
    {
        private List<Planet> planets = new List<Planet>();
        System.Media.SoundPlayer music = new System.Media.SoundPlayer();
        public SolarSystem()
        {
            InitializeComponent();
            PlanetArea();
            music.SoundLocation = "spacecut.wav";
            music.Play();
        }
        public void PlanetArea()
        {
            planets.Add(new Sun());
            planets.Add(new Mercury());
            planets.Add(new Venus());
            planets.Add(new Earth());
            planets.Add(new Mars());
            planets.Add(new Jupiter());
            planets.Add(new Saturn());
            planets.Add(new Uranus());
            var area = planets
                .Select(x => x.Area())
                .Sum();
            toolStripStatusLabelPlanetArea.Text = "Planet Area: " + area;
        }

        private void SolarSystem_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
