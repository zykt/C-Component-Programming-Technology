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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.Width = Screen.PrimaryScreen.WorkingArea.Width / 2;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height / 2;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2,
                                      Screen.PrimaryScreen.WorkingArea.Bottom - this.Height);
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.form3 = null;
        }
    }
}
