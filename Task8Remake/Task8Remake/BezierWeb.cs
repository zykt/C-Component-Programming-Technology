using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Task8Remake
{
    public class Bezier
    {
        public Point StartPoint { get; set; }

        public Point ControlPoint1 { get; set; }

        public Point ControlPoint2 { get; set; }

        public Point EndPoint { get; set; }

        public Bezier(Point start, Point control1, Point control2, Point end)
        {
            this.StartPoint = start;
            this.ControlPoint1 = control1;
            this.ControlPoint2 = control2;
            this.EndPoint = end;
            //this.ControlPoint1 = new Point(0, this.Target.Size.Height);
            //this.ControlPoint2 = new Point(0, 0);
            //this.EndPoint = new Point(this.Target.Size.Width, 0);
        }
    }

    public class BezierWeb : AbstractDisplayComponent
    {
        public Pen BezierPen { get; set; }

        public Bezier[] Lines { get; set; }

        public BezierWeb(Control target)
        {
            this.Target = target;
            this.Graphic = this.Target.CreateGraphics();

            this.BezierPen = new Pen(Color.Green);

            Bezier b1 = new Bezier(new Point(this.CenterX, this.CenterY),
                                   new Point(0, this.Target.Size.Height),
                                   new Point(0, 0),
                                   new Point(this.Target.Size.Width, 0));
            Bezier b2 = new Bezier(new Point(this.CenterX, this.CenterY),
                                   new Point(this.Target.Size.Width, this.Target.Size.Height),
                                   new Point(this.Target.Size.Width, 0),
                                   new Point(0, 0));
            Bezier b3 = new Bezier(new Point(this.CenterX, this.CenterY),
                                   new Point(0, this.Target.Size.Height),
                                   new Point(this.Target.Size.Width, this.Target.Size.Height),
                                   new Point(this.CenterX, CenterX));
            Bezier b4 = new Bezier(new Point(this.CenterX, this.CenterY),
                                   new Point(this.Target.Size.Width, this.Target.Size.Height),
                                   new Point(0, this.Target.Size.Height),
                                   new Point(this.CenterX, CenterX));

            this.Lines = new Bezier[] { b1, b2, b3, b4 };
        }

        public void Draw()
        {
            this.Clear();
            foreach (Bezier b in this.Lines)
            {
                this.Graphic.DrawBezier(this.BezierPen, b.StartPoint, b.ControlPoint1, b.ControlPoint2, b.EndPoint);
            }
        }

        public void OnMouseMove(object sender, MouseEventArgs e)
        {
            foreach (Bezier b in this.Lines)
            {
                b.StartPoint = e.Location;
            }
            this.Draw();
        }
    }
}
