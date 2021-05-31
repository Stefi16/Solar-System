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

namespace Solar_System
{
    public partial class AdditionalInformation : Form
    {
        private List<Planet> allPlanets = Adder.AllPlanets();
        private List<CosmicalObject> cosmicalObjects = Adder.AllCosmicalObjects();
        private List<Planet> dwarfPlanets = Adder.DwarfPlanets();
        public AdditionalInformation()
        {
            InitializeComponent();
        }
        private void AdditionalInformation_Load(object sender, EventArgs e)
        {

            var co = cosmicalObjects.OrderBy(x => x.Radius);
            for (int i = 0; i < co.Count(); i++)
            {
                listBoxPlanetRadius.Items.Add($"{i + 1}. {co.ElementAt(i).Name}: " + co.ElementAt(i).Radius + " km.");
            }

            var ap = allPlanets.OrderBy(x => x.Temperature);
            for (int i = 0; i < ap.Count(); i++)
            {
                listBoxTemperature.Items.Add($"{i + 1}. {ap.ElementAt(i).Name}: " + ap.ElementAt(i).Temperature + " celsius.");
            }

            var daysInYear = cosmicalObjects
                .Skip(1)
                .OrderBy(x => x.DaysInAnYear);
            for (int i = 0; i < daysInYear.Count(); i++)
            {
                listBoxDaysInAnYear.Items.Add($"{i + 1}. {daysInYear.ElementAt(i).Name}: "
                    + daysInYear.ElementAt(i).DaysInAnYear + " days.");
            }

            var dwarfArea = dwarfPlanets
                .OrderBy(x => x.Area());
            for (int i = 0; i < dwarfArea.Count(); i++)
            {
                listBoxDwarfArea.Items.Add($"{i + 1}. {dwarfArea.ElementAt(i).Name}: "
                    + dwarfArea.ElementAt(i).Area() + " sqare km.");
            }

            var largestPlanets = allPlanets
                .OrderByDescending(x => x.Radius)
                .Take(3);
            for (int i = 0; i < largestPlanets.Count(); i++)
            {
                listBox3LargestPlanets.Items.Add($"{i + 1}. {largestPlanets.ElementAt(i).Name}");
            }

            var planet = new Planet();
            var infoP = planet.Information().Split();
            listBoxPlanetInfo.Items.Add($"{infoP[0]} {infoP[1]} {infoP[2]} {infoP[3]} {infoP[4]} {infoP[5]}");
            listBoxPlanetInfo.Items.Add($"{infoP[6]} {infoP[7]} {infoP[8]} {infoP[9]} {infoP[10]} {infoP[11]}");
            listBoxPlanetInfo.Items.Add($"{infoP[12]} {infoP[13]} {infoP[14]} {infoP[15]} {infoP[16]} {infoP[17]}");
            listBoxPlanetInfo.Items.Add($"{infoP[18]} {infoP[19]} {infoP[20]} {infoP[21]} {infoP[22]} {infoP[23]}");
            listBoxPlanetInfo.Items.Add($"{infoP[24]} {infoP[25]} {infoP[26]} {infoP[27]} {infoP[28]}");
            listBoxPlanetInfo.Items.Add($"{infoP[29]} {infoP[30]}.");

            var asteroid = new Asteroid();
            var infoA = asteroid.Information().Split();
            listBoxAsteroidInfo.Items.Add($"{infoA[0]} {infoA[1]} {infoA[2]} {infoA[3]}");
            listBoxAsteroidInfo.Items.Add($"{infoA[4]} {infoA[5]} {infoA[6]} {infoA[7]} {infoA[8]}");
            listBoxAsteroidInfo.Items.Add($"{infoA[9]} {infoA[10]} {infoA[11]} {infoA[12]} {infoA[13]}");
            listBoxAsteroidInfo.Items.Add($"{infoA[14]} {infoA[15]} {infoA[16]} {infoA[17]} {infoA[18]} {infoA[19]}");
            listBoxAsteroidInfo.Items.Add($"{infoA[20]} {infoA[21]} {infoA[22]} {infoA[23]} {infoA[24]} {infoA[25]}");
            listBoxAsteroidInfo.Items.Add($"{infoA[26]} {infoA[27]} {infoA[28]} {infoA[29]} {infoA[30]} {infoA[31]}");
            listBoxAsteroidInfo.Items.Add($"{infoA[32]} {infoA[33]} {infoA[34]} {infoA[35]}");
        }
    }
    
}
