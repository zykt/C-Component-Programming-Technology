using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Task8Remake
{
    public class Plotter : AbstractDisplayComponent
    {
        public Pen AxisPen { get; set; }

        public Pen PlotPen { get; set; }

        public Plotter(Control target)
        {
            this.AxisPen = new Pen(Color.Gray, 1);
            this.PlotPen = new Pen(Color.Blue, 1);
            this.Target = target;
            this.Graphic = this.Target.CreateGraphics();
        }

        public void DrawAxes()
        {
            this.Graphic.DrawLine(this.AxisPen, 0, this.CenterY, this.Target.Size.Width, this.CenterY);
            this.Graphic.DrawLine(this.AxisPen, this.CenterX, 0, this.CenterX, this.Target.Size.Height);
        }

        public void Plot(Func<float, float> f, float start, float end, float step)
        {
            PointF[] points = Range(start, end, step)
                .Select(d
                    => new PointF(this.CenterX + d, this.CenterY - f(d)))
                .ToArray();
            this.DrawAxes();
            this.Graphic.DrawLines(this.PlotPen, points);
        }

        private static IEnumerable<float> Range(float start, float end, float step = 0.1f)
        {
            int count = Convert.ToInt32((end - start) / step);
            for (int i = 0; i < count; i++)
            {
                yield return start + step * i;
            }
            yield return end;
        }
    }
}
