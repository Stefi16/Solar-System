using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solar_System
{
    public partial class InputWeight : Form
    {
        private List<Rectangle> rectangles = Adder.RectangleAdder();
        Random randomizer = new Random();
        List<Color> colors = Adder.Colors();
        private bool leftClick = false;
        private Point leftMouseDownLocation;
        public InputWeight()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint
               | ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
        }

        private void InputWeight_Load(object sender, EventArgs e)
        {

            using (Graphics graphics = CreateGraphics())
            {
                foreach (var rect in rectangles)
                {
                    rect.PaintRectangle(graphics);
                }

            }
            if (File.Exists("rectangles"))
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream str = new FileStream("rectangles", FileMode.Open, FileAccess.Read))
                {
                    rectangles = (List<Rectangle>)formatter.Deserialize(str);
                }
            }

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (var rect in rectangles)
            {
                rect.PaintRectangle(e.Graphics);
            }
        }

        private void InputWeight_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                leftMouseDownLocation = e.Location;
                leftClick = true;
                foreach (var rect in rectangles)
                {
                    var randomNumber = randomizer.Next(0, colors.Count - 1);
                    if (rect.Contains(e.Location))
                    {
                        rect.Color = colors.ElementAtOrDefault(randomNumber);
                    }
                    Invalidate();
                    Application.DoEvents();
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                foreach (var rect in rectangles)
                {
                    rect.Color = Color.Red;
                }
                Invalidate();
                Application.DoEvents();
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            var text = textBoxWeight.Text;
            if (text.Length == 0 || !char.IsDigit(text[0]) || text[0] == '0') 
            {
                MessageBox.Show("Please enter a positive number larger than and not starting with 0.");
                textBoxWeight.Clear();
                return;
            }
            V.Weight = int.Parse(text);
            Close();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if(V.Weight == default)
            {
                MessageBox.Show("There is no previously saved number.");
                textBoxWeight.Clear();
                return;
            }
            Close();
        }

        private void InputWeight_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftClick)
            {
                foreach (var rect in rectangles)
                {
                    if (rect.Contains(leftMouseDownLocation))
                    {
                        rect.Position = new Point((e.X - leftMouseDownLocation.X) + rect.TopXLeft, (e.Y - leftMouseDownLocation.Y) + rect.TopYLeft);
                        leftMouseDownLocation = e.Location;
                        this.Invalidate();
                    }
                }

            }
        }

        private void InputWeight_MouseUp(object sender, MouseEventArgs e)
        {
            leftClick = false;
        }

        private void InputWeight_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var rec in rectangles)
            {
                rec.Position = rec.OriginalPosition;
            }
            IFormatter formatter = new BinaryFormatter();
            using (Stream str = new FileStream("rectangles", FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(str, rectangles);
            }
        }


        private void textBoxWeight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonDone_Click(sender, e);
            }
        }
    }
}
