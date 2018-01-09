using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Task2._2
{
    public partial class Form1 : Form
    {
        private Point _oldSize { get; set; }

        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            Global.form1 = this;
            this.StartPosition = FormStartPosition.CenterScreen;
            _oldSize = new Point(this.Width, this.Height);
        }

        private void form2Button_Click(object sender, EventArgs e)
        {
            if (Global.form2 == null)
                Global.form2 = new Form2();
            Global.form2.Show();
        }

        private void form3Button_Click(object sender, EventArgs e)
        {
            if (Global.form3 == null)
                Global.form3 = new Form3();
            Global.form3.Show();
        }

        private void form11Button_Click(object sender, EventArgs e)
        {
            if (Global.form11 == null)
                Global.form11 = new Form11();
            Global.form11.Show();
        }

        private void form12Button_Click(object sender, EventArgs e)
        {
            if (Global.form12 == null)
                Global.form12 = new Form12();
            Global.form12.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.form1 = null;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Double xScale = Convert.ToDouble(this.Width) / _oldSize.X;
            Double yScale = Convert.ToDouble(this.Height) / _oldSize.Y;
            //foreach (var child in this.MdiChildren)
            //{
            //    child.Width = (int) xScale * child.Width;
            //    child.Height = (int) yScale * child.Height;
            //    Console.WriteLine(xScale);
            //    Console.WriteLine(child.Width);
            //}
            if (Global.form11 != null)
            {
                //Global.form11.WidthFromDouble = xScale * Global.form11.WidthFromDouble;
                //Global.form11.HeightFromDouble = yScale * Global.form11.HeightFromDouble;
                Global.form11.Scale(xScale, yScale);
                Console.WriteLine(xScale);
                Console.WriteLine(Global.form11.WidthFromDouble);
            }
            _oldSize = new Point(this.Width, this.Height);
        }
    }
}
