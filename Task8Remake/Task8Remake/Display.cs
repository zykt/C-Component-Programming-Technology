using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task8Remake
{
    public partial class Display : UserControl
    {
        public Graphics Graphic { get; private set; }

        public enum DisplayMode
        {
            Plotter,
            TrianglesAndCircles,
            BezierWeb,
            RandomShapes
        }

        public DisplayMode Mode { get; set; }

        public Plotter Plotter { get; private set; }

        public TrianglesAndCircles TrianglesAndCircles { get; private set; }

        public BezierWeb BezierWeb { get; private set; }

        public RandomShapes RandomShapes { get; private set; }
        
        public Display()
        {
            InitializeComponent();
            this.Graphic = this.CreateGraphics();
            this.Plotter = new Plotter(this);
            this.TrianglesAndCircles = new TrianglesAndCircles(this);
            this.BezierWeb = new BezierWeb(this);
            this.RandomShapes = new RandomShapes(this);
        }

        public void InitPlotter()
        {
            this.Mode = DisplayMode.Plotter;
        }

        public void InitTrianglesAndCircles()
        {
            this.Mode = DisplayMode.TrianglesAndCircles;
        }

        public void InitBezierWeb()
        {
            this.Mode = DisplayMode.BezierWeb;
        }

        public void InitRandomShapes()
        {
            this.Mode = DisplayMode.RandomShapes;
        }

        public void Clear()
        {
            this.Graphic.Clear(Color.White);
        }

        private void Display_MouseClick(object sender, MouseEventArgs e)
        {
            // Debug Rectangle
            // this.Graphic.DrawRectangle(new Pen(Color.Red), 10, 10, 20, 20);
            switch (this.Mode) {
                case DisplayMode.Plotter: break;
                case DisplayMode.TrianglesAndCircles: this.TrianglesAndCircles.OnClick(sender, e); break;
                case DisplayMode.RandomShapes: this.RandomShapes.Draw(); break;
            }
        }

        private void Display_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            switch (this.Mode)
            {
                case DisplayMode.Plotter: break;
                case DisplayMode.TrianglesAndCircles: this.TrianglesAndCircles.Clear(); break;
                case DisplayMode.BezierWeb: this.BezierWeb.Clear(); break;
                case DisplayMode.RandomShapes: this.RandomShapes.Clear(); break;
            }
        }

        private void Display_MouseMove(object sender, MouseEventArgs e)
        {
            switch (this.Mode)
            {
                case DisplayMode.BezierWeb: this.BezierWeb.OnMouseMove(sender, e); break;
            }
        }
    }
}
