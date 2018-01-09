using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task8Remake
{
    public partial class Form1 : Form
    {
        private Plotter Plot { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void PlotterButton_Click(object sender, EventArgs e)
        {
            this.display1.Clear();
            this.display1.InitPlotter();
            this.display1.Plotter.Plot(x => x * x, -20, 20, 0.1f);
        }

        private void TrianglesButton_Click(object sender, EventArgs e)
        {
            this.display1.Clear();
            this.display1.InitTrianglesAndCircles();
        }

        private void BezierButton_Click(object sender, EventArgs e)
        {
            this.display1.Clear();
            this.display1.InitBezierWeb();
            this.display1.BezierWeb.Draw();
        }

        private void ShapesButton_Click(object sender, EventArgs e)
        {
            this.display1.Clear();
            this.display1.InitRandomShapes();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }
    }

}
