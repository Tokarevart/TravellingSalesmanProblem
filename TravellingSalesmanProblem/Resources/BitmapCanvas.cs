using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TravellingSalesmanProblem.Resources
{
    class BitmapCanvas
    {
        private PictureBox PictureBox { get; set; }
        private Graphics Graphics { get; set; }
        private Bitmap Bitmap { get; set; }
        private Color ClearColor { get; set; }

        public BitmapCanvas(PictureBox pictureBox, int width, int height)
        {
            Bitmap = new Bitmap(width, height);
            Graphics = Graphics.FromImage(Bitmap);
            Graphics.SmoothingMode = SmoothingMode.HighQuality;
            PictureBox = pictureBox;
            ClearColor = Color.White;
            pictureBox.Image = Bitmap;

            Clear();
        }

        public BitmapCanvas(PictureBox pictureBox, int width, int height, Color clearColor)
        {
            Bitmap = new Bitmap(width, height);
            Graphics = Graphics.FromImage(Bitmap);
            Graphics.SmoothingMode = SmoothingMode.HighQuality;
            PictureBox = pictureBox;
            ClearColor = clearColor;
            pictureBox.Image = Bitmap;

            Clear();
        }

        public void CreateBitmap(int width, int height)
        {
            Bitmap = new Bitmap(width, height);
            Graphics = Graphics.FromImage(Bitmap);
            Graphics.SmoothingMode = SmoothingMode.HighQuality;

            PictureBox.Image = Bitmap;
        }

        public void DrawEllipse(Rectangle rect, Pen borderPen, Brush fillBrush)
        {
            Graphics.FillEllipse(fillBrush, rect);
            Graphics.DrawEllipse(borderPen, rect);

            PictureBox.Refresh();
        }

        public void DrawLine(Pen pen, Point p0, Point p1)
        {
            Graphics.DrawLine(pen, p0, p1);

            PictureBox.Refresh();
        }

        public void DrawString(string s, Font font, Brush brush, PointF point)
        {
            Graphics.DrawString(s, font, brush, point);
            
            PictureBox.Refresh();
        }

        public void Clear()
        {
            Graphics.Clear(ClearColor);

            PictureBox.Refresh();
        }
    }
}
