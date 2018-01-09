using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Task8Remake
{
    public abstract class AbstractDisplayComponent
    {
        public Graphics Graphic { get; protected set; }

        public Control Target { get; set; }

        public int CenterX
        {
            get => this.Target.Size.Width / 2;
        }

        public int CenterY
        {
            get => this.Target.Size.Height / 2;
        }

        public virtual void Clear()
        {
            this.Graphic.Clear(Color.White);
        }
    }
}
