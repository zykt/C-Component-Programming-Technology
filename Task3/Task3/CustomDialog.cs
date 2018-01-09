using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class CustomDialog : Form
    {
        public CustomDialog()
        {
            InitializeComponent();
        }
        
        public static DialogResult Show(String text,
                                 String title="Dialog",
                                 String button1="Ok",
                                 String button2="Cancel")
        {
            CustomDialog cd = new CustomDialog();

            cd.message.Text = text;
            cd.Text = title;
            cd.button1.Text = button1;
            cd.button2.Text = button2;

            return cd.ShowDialog();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
