using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Task2._1
{
    public partial class IntroForm : Form
    {
        public IntroForm()
        {
            InitializeComponent();
        }

        private void NextFormButton_Click(object sender, EventArgs e)
        {
            if (GlobalForms.calcForm == null) {
                GlobalForms.calcForm = new CalcForm();
                GlobalForms.calcForm.Show();
                this.Hide();
            } else {
                GlobalForms.calcForm.Show();
                this.Hide();
            }
        }
    }
}
