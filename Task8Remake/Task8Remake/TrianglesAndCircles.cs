using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Task8Remake
{
    public class CircumCircle
    {
        public int Radius { get; private set; }

        public Point Center { get; private set; }

        public CircumCircle(Point A, Point B, Point C)
        {
            Double side1 = A.Substract(B).Length();
            Double side2 = B.Substract(C).Length();
            Double side3 = C.Substract(A).Length();
            Double p = (side1 + side2 + side3) / 2;
            Double s = Math.Sqrt((p - side1) * (p - side2) * (p - side3) * p);
            this.Radius = Convert.ToInt32((side1 * side2 * side3 / (4 * s)));

            int D = 2 * (A.X * (B.Y - C.Y) + B.X * (C.Y - A.Y) + C.X * (A.Y - B.Y));
            int X = ((A.X * A.X + A.Y * A.Y) * (B.Y - C.Y) + (B.X * B.X + B.Y * B.Y) * (C.Y - A.Y) + (C.X * C.X + C.Y * C.Y) * (A.Y - B.Y)) / D;
            int Y = ((A.X * A.X + A.Y * A.Y) * (C.X - B.X) + (B.X * B.X + B.Y * B.Y) * (A.X - C.X) + (C.X * C.X + C.Y * C.Y) * (B.X - A.X)) / D;
            this.Center = new Point(X, Y);
        }
    }

    public class InCircle
    {
        public int Radius { get; private set; }

        public Point Center { get; private set; }

        public InCircle(Point A, Point B, Point C)
        {
            Double side1 = A.Substract(B).Length();
            Double side2 = B.Substract(C).Length();
            Double side3 = C.Substract(A).Length();
            Double p = (side1 + side2 + side3) / 2;
            Double s = Math.Sqrt((p - side1) * (p - side2) * (p - side3) * p);
            this.Radius = Convert.ToInt32(s / p);

            int X = Convert.ToInt32((side2 * A.X + side3 * B.X + side1 * C.X) / (side1 + side2 + side3));
            int Y = Convert.ToInt32((side2 * A.Y + side3 * B.Y + side1 * C.Y) / (side1 + side2 + side3));
            this.Center = new Point(X, Y);
        }
    }

    public class TrianglesAndCircles : AbstractDisplayComponent
    {
        public Pen TrianglesPen { get; set; }

        public Pen CirclesPen { get; set; }

        public Pen PointPen { get; set; }

        public Point? PointA { get; set; }

        public Point? PointB { get; set; }
        
        public Point? PointC { get; set; }

        public TrianglesAndCircles(Control target)
        {
            this.TrianglesPen = new Pen(Color.Red, 1);
            this.CirclesPen = new Pen(Color.Blue, 2);
            this.PointPen = new Pen(Color.Black, 1);
            this.Target = target;
            this.Graphic = this.Target.CreateGraphics();
        }

        public override void Clear()
        {
            this.PointA = null;
            this.PointB = null;
            this.PointC = null;
            this.Graphic.Clear(Color.White);
        }


        /*
        ** Events 
        */

        public void OnClick(object sender, MouseEventArgs e)
        {
            if (this.PointA == null)
            {
                this.PointA = e.Location;
                this.Graphic.DrawPoint(this.PointPen, this.PointA.Value);
            } else if (this.PointB == null)
            {
                this.PointB = e.Location;
                this.Graphic.DrawPoint(this.PointPen, this.PointB.Value);
            } else if (this.PointC == null)
            {
                this.PointC = e.Location;
                this.Graphic.DrawPoint(this.PointPen, this.PointC.Value);
                this.Graphic.DrawTriangle(this.TrianglesPen, (Point)PointA, (Point)PointB, (Point)PointC);

                CircumCircle circum = new CircumCircle(this.PointA.Value, this.PointB.Value, this.PointC.Value);
                InCircle incircle = new InCircle(this.PointA.Value, this.PointB.Value, this.PointC.Value);

                this.Graphic.DrawCircle(this.CirclesPen, circum.Center, circum.Radius);
                this.Graphic.DrawCircle(this.CirclesPen, incircle.Center, incircle.Radius);
            }
        }
    }
}
