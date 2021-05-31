using System;
using System.Drawing;

namespace Solar_System
{
    [Serializable]
    public class Ellipse
    {
        public Color MyColor { get; set; }
        public Point Location { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Ellipse()
        {

        }
        public Ellipse(Point pointy, int width, int height)
        {
            this.Location = new Point(pointy.X, pointy.Y);
            this.Width = width;
            this.Height = height;
        }
        public void Paint(Graphics graphy)
        {
            using (Pen pen = new Pen(MyColor, 4))
            {
                graphy.DrawEllipse(pen, this.Location.X, this.Location.Y, this.Width, this.Height);
            }
        }
        public bool ContainsEllipse(Point pointy)
        {

            Point center = new Point(
                  this.Location.X + this.Width / 2,
                  this.Location.Y + this.Height / 2);

            double radiusX = this.Width / 2;
            double radiusY = this.Height / 2;
            var point = new Point(pointy.X - center.X, pointy.Y - center.Y);
            double result = ((point.X * point.X) / (radiusX * radiusX)) + ((point.Y * point.Y) / (radiusY * radiusY));

            if (result >= 0.95 && result <= 1.029)
                return true;

            return false;

        }
    }
}
