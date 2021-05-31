using System;
using System.Drawing;

namespace Solar_System
{
    [Serializable]
    public class Rectangle
    {
        public Point Position { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public Color Color { get; set; }
        public Point OriginalPosition { get; set; }
        public int TopYLeft => Position.Y;
        public int TopXLeft => Position.X;

        public Rectangle()
        {

        }

        public Rectangle(Color color, Point point, int width, int height)
        {
            this.Color = color;
            this.Position = point;
            this.Width = width;
            this.Height = height;

        }
        public void PaintRectangle(Graphics graphics)
        {
            using (SolidBrush brushy = new SolidBrush(
                Color.FromArgb(
                Math.Min(byte.MaxValue, Color.R + 54),
                Math.Min(byte.MaxValue, Color.G + 80),
                Math.Min(byte.MaxValue, Color.B + 66))))
            {
                graphics.FillRectangle(brushy, Position.X, Position.Y, Width, Height);
            }
            using (Pen pen = new Pen(Color, 4))
            {
                graphics.DrawRectangle(pen, Position.X, Position.Y, Width, Height);
            }
        }

        public bool Contains(Point point)
        {
            return Position.X < point.X && point.X < Position.X + Width &&
                Position.Y < point.Y && point.Y < Position.Y + Height;
        }
    }
}
