using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Task8Remake
{
    public class RandomShapes : AbstractDisplayComponent
    {
        public Random Random { get; set; }

        public RandomShapes(Control target)
        {
            this.Target = target;
            this.Graphic = this.Target.CreateGraphics();
            this.Random = new Random();
        }

        public Brush NewEllipseBrush(Rectangle rect)
        {
            return new LinearGradientBrush(rect, RandomColor(), RandomColor(), LinearGradientMode.Vertical);
        }

        public Brush NewArcBrush()
        {
            return new SolidBrush(RandomColor());
        }

        public Brush NewRectangleBrush()
        {
            return new HatchBrush(HatchStyle.Cross, RandomColor());
        }

        public void Draw()
        {
            Random r = new Random();
            Rectangle randomRectangle()
            {
                int x = r.Next(1, this.Target.Size.Width);
                int y = r.Next(1, this.Target.Size.Height);
                int width = r.Next(1, this.Target.Size.Width - x);
                int height = r.Next(1, this.Target.Size.Height - y);
                return new Rectangle(x, y, width, height);
            }
                
            Rectangle EllipseRectangle = randomRectangle();
            this.Graphic.FillEllipse(this.NewEllipseBrush(EllipseRectangle), EllipseRectangle);
            this.Graphic.FillPie(this.NewArcBrush(), randomRectangle(), r.Next(360), r.Next(360));
            this.Graphic.FillRectangle(this.NewRectangleBrush(), randomRectangle());
        }

        public void OnClick()
        {
            this.Draw();
        }

        private Color RandomColor()
        {
            return Color.FromArgb(this.Random.Next(256), this.Random.Next(256), this.Random.Next(256));
        }
    }
}
