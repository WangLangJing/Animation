using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Animation.Test
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            base.Load += new EventHandler(this.Form2_Load);
            base.Paint += new PaintEventHandler(this.Form2_Paint);
            base.Resize += new EventHandler(this.Form2_Resize);
        }

 

        private void DrawCone(Graphics g, Point xy1, float r)
        {
            float height = g.VisibleClipBounds.Height;
            RectangleF rect = new RectangleF(xy1.X - r, height - ((float)(xy1.Y - (1.49 * r))), 2f * r, r);
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect, 180f, -180f);
            using (LinearGradientBrush brush = new LinearGradientBrush(rect, Color.Gray, Color.WhiteSmoke, 190f))
            {
                g.FillPath(brush, path);
                path.Reset();
                Point point = xy1;
                point.Offset((int)Math.Round((double)-r), (int)Math.Round((double)(-2f * r)));
                Point point2 = xy1;
                point2.Offset((int)Math.Round((double)r), (int)Math.Round((double)(-2f * r)));
                PointF[] thePolygon = new PointF[] { point, xy1, point2 };
                this.ReverseY(ref thePolygon, height);
                path.AddLines(thePolygon);
                g.FillPath(brush, path);
            }
        }

        private void DrawCube(Graphics g, float w, float h, float d, Point xy1)
        {
            Point point=Point.Empty;
            float height = g.VisibleClipBounds.Height;
            GraphicsPath path = new GraphicsPath();
            d *= 0.7f;
            Graphics graphics = g;
            using (SolidBrush brush = new SolidBrush(Color.LightGray))
            {
                graphics.FillRectangle(brush, (float)xy1.X, height - xy1.Y, w, h);
            }
       
            point.X = (int)Math.Round((double)(xy1.X + (d * Math.Cos(0.52356020942408377))));
            point.Y = (int)Math.Round((double)(xy1.Y + (d * Math.Sin(0.52356020942408377))));
            Point point2 = point;
            point2.Offset((int)Math.Round((double)w), 0);
            Point point3 = xy1;
            point3.Offset((int)Math.Round((double)w), 0);
            PointF[] thePolygon = new PointF[] { xy1, point, point2, point3 };
            this.ReverseY(ref thePolygon, height);
            path.AddLines(thePolygon);
            using (PathGradientBrush brush2 = new PathGradientBrush(path))
            {
                brush2.CenterPoint = new PointF(2f * w, height);
                brush2.CenterColor = Color.SteelBlue;
                graphics.FillPath(brush2, path);
            }
  
            point = point3;
            point3 = point2;
            point3.Offset(0, (int)Math.Round((double)-h));
            Point point4 = point;
            point4.Offset(0, (int)Math.Round((double)-h));
            thePolygon = new PointF[] { point, point2, point3, point4 };
            this.ReverseY(ref thePolygon, height);
            path.Reset();
            path.AddLines(thePolygon);
            using (PathGradientBrush brush3 = new PathGradientBrush(path))
            {
                brush3.CenterPoint = new PointF(2f * w, height);
                brush3.CenterColor = Color.SlateGray;
                graphics.FillPath(brush3, path);
            }
            goto DIS;
DIS:
            graphics = null;
        }

        private void DrawCylinder(Graphics g, Point xy1, int h, float r)
        {
            float height = g.VisibleClipBounds.Height;
            RectangleF rect = new RectangleF(xy1.X - r, height - ((float)((xy1.Y + (((double)r) / 1.9)) - h)), 2f * r, r);
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect, 180f, -180f);
            using (LinearGradientBrush brush = new LinearGradientBrush(rect, Color.Gray, Color.WhiteSmoke, 180f))
            {
                g.FillPath(brush, path);
                path.Reset();
                Point point = xy1;
                point.Offset((int)Math.Round((double)-r), 0);
                Point point2 = point;
                point2.Offset(0, 0 - h);
                Point point3 = xy1;
                point3.Offset((int)Math.Round((double)r), 0);
                Point point4 = point3;
                point4.Offset(0, 0 - h);
                PointF[] thePolygon = new PointF[] { point2, point, point3, point4 };
                this.ReverseY(ref thePolygon, height);
                path.AddLines(thePolygon);
                g.FillPath(brush, path);
            }
            path.Reset();
            rect.Offset(0f, (float)(0 - h));
            path.AddEllipse(rect);
            using (PathGradientBrush brush2 = new PathGradientBrush(path))
            {
                brush2.CenterPoint = new PointF(xy1.X + r, height - r);
                brush2.CenterColor = Color.Gray;
                g.FillPath(brush2, path);
            }
        }

        private void DrawGrid(Graphics g, float theScale)
        {
            float height = g.VisibleClipBounds.Height;
            float emSize = theScale / 25f;
            using (Font font = new Font("Arial", emSize))
            {
                using (Pen pen = new Pen(Color.SkyBlue, theScale / 500f))
                {
                    using (SolidBrush brush = new SolidBrush(Color.LightGray))
                    {
                        float y = height - ((float)(1.5 * emSize));
                        float num5 = theScale;
                        for (float i = 0f; i <= num5; i += 5f)
                        {
                            g.DrawLine(pen, i, height - 0f, i, height - theScale);
                            g.DrawString(i.ToString(), font, brush, i, y);
                            float num4 = height - (((float)(1.5 * emSize)) + i);
                            g.DrawLine(pen, 0f, height - i, theScale, height - i);
                            g.DrawString(i.ToString(), font, brush, 0f, num4);
                        }
                    }
                }
            }
        }

        private void DrawSphere(Graphics g, float x, float y, float r)
        {
            float height = g.VisibleClipBounds.Height;
            RectangleF rect = new RectangleF(x - r, height - (y + r), 2f * r, 2f * r);
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(rect);
            rect.X += r / 50f;
            rect.Y += r / 50f;
            g.DrawEllipse(new Pen(Color.LightGray, r / 16f), rect);
            using (PathGradientBrush brush = new PathGradientBrush(path))
            {
                brush.CenterPoint = new PointF(x + r, height - 10f);
                brush.CenterColor = Color.Gray;
                Color[] colorArray = new Color[] { Color.WhiteSmoke };
                brush.SurroundColors = colorArray;
                g.FillPath(brush, path);
                brush.CenterColor = Color.LightGray;
                rect.Width *= 0.2f;
                rect.Height *= 0.2f;
                rect.Offset(r / 3f, r / 2f);
                g.FillEllipse(brush, rect);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            float theScale = 35f;
            float sx = ((float)base.ClientSize.Width) / theScale;
           // graphics.ScaleTransform(sx, sx);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.Clear(Color.Black);
         //   this.DrawGrid(e.Graphics, theScale);
            this.DrawCube(e.Graphics, 300f, 500f, 100f, new Point(14,550));
            //this.DrawSphere(e.Graphics, 9f, 15f, 6f);
            //this.DrawCone(e.Graphics, new Point(0x1a, 0x15), 6f);
            //this.DrawCylinder(e.Graphics, new Point(0x11, 0x11), 10, 4f);
            graphics = null;
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            base.Invalidate();
        }

      

        private void ReverseY(ref PointF[] thePolygon, float yoffset)
        {
            int num = thePolygon.Length - 1;
            for (int i = 0; i <= num; i++)
            {
                thePolygon[i].Y = yoffset - thePolygon[i].Y;
            }
        }
    }
}
