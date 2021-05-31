using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;


namespace Solar_System
{

    public partial class InputAge : Form
    {
        private List<Rectangle> squares = Adder.SquareAdder();
        Random randomizer = new Random();
        List<Color> colors = Adder.Colors();
        private bool leftClick = false;
        private Point leftMouseDownLocation;
        public InputAge()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint
                | ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
        }

        private void Input_Load(object sender, EventArgs e)
        {
            using (Graphics graph = CreateGraphics())
            {
                foreach (var sq in squares)
                {
                    sq.PaintRectangle(graph);
                }

            }
            
            if (File.Exists("squares"))
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream str = new FileStream("squares", FileMode.Open, FileAccess.Read))
                {
                    squares = (List<Rectangle>)formatter.Deserialize(str);
                }
            }
            
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (var sq in squares)
            {
                sq.PaintRectangle(e.Graphics);
            }
        }

        private void Input_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                leftMouseDownLocation = e.Location;
                leftClick = true;
                foreach (var sq in squares)
                {
                    var randomNumber = randomizer.Next(0, colors.Count - 1);
                    if (sq.Contains(e.Location))
                    {
                        sq.Color = colors.ElementAtOrDefault(randomNumber);
                    }
                    else if (!sq.Contains(e.Location) && sq.Color != Color.DarkOrange)
                    {
                        sq.Color = Color.DarkOrange;
                    }
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                foreach (var sq in squares)
                {
                    sq.Color = Color.DarkOrange;
                }
            }
            Invalidate();
            Application.DoEvents();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            var t = textBoxAge.Text;
            if (t.Length == 0 || !char.IsDigit(t[0]) || t[0] == '0')
            {
                MessageBox.Show("Please, enter a positive number and it shouldn't start with or be equal to 0!");
                textBoxAge.Clear();
                return;
            }
            V.Age = int.Parse(t);
            Close();
        }

        private void textBoxAge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonDone_Click(sender, e);
            }

        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (V.Age == default)
            {
                MessageBox.Show("There is no previous age detected.");
            }
            else
            {
                Close();
            }

        }

        private void InputAge_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftClick)
            {
                foreach (var sq in squares)
                {
                    if (sq.Contains(leftMouseDownLocation))
                    {
                        sq.Position = new Point((e.X - leftMouseDownLocation.X) + sq.TopXLeft, (e.Y - leftMouseDownLocation.Y) + sq.TopYLeft);
                        leftMouseDownLocation = e.Location;
                        this.Invalidate();
                    }
                }

            }

        }

        private void InputAge_MouseUp(object sender, MouseEventArgs e)
        {
            leftClick = false;
        }

        private void InputAge_FormClosing(object sender, FormClosingEventArgs e)
        {
            //сериализация
            foreach (var sq in squares)
            {
                sq.Position = sq.OriginalPosition;
            }
            IFormatter formatter = new BinaryFormatter();
            using (Stream str = new FileStream("squares", FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(str, squares);
            }
        }
    }
}
