using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Task8Remake
{
    public static class Extensions
    {
        public static void DrawTriangle(this Graphics g, Pen pen, Point a, Point b, Point c)
        {
            GraphicsPath triangle = new GraphicsPath();
            triangle.AddLines(new Point[] { a, b, c, a });
            g.DrawPath(pen, triangle);
        }

        public static void DrawPoint(this Graphics g, Pen pen, Point p)
        {
            g.DrawRectangle(pen, p.X, p.Y, 1, 1);
        }

        public static void DrawCircle(this Graphics g, Pen pen, Point center, int radius)
        {
            g.DrawArc(pen, center.X - radius, center.Y - radius, radius * 2, radius * 2, 0, 360);
            // g.DrawPoint(new Pen(Color.Black, 2), new Point(X, Y));
        }

        public static Point Add(this Point A, Point B) =>
            new Point(A.X + B.X, A.Y + B.Y);

        public static Point Substract(this Point A, Point B) =>
            new Point(A.X - B.X, A.Y - B.Y);

        public static Double Length(this Point A) =>
            Math.Sqrt(A.X * A.X + A.Y * A.Y);

        public static Point Scale(this Point A, int s) =>
            new Point(A.X * s, A.Y * s);
    }
}
