using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class Input : UserControl
    {
        public Input()
        {
            InitializeComponent();
        }

        [Category("Size")]
        public int Rows
        {
            get => Convert.ToInt16(this.rows.Value);
            set => this.rows.Value = value;
        }
         
        [Category("Size")]
        public int Columns
        {
            get => Convert.ToInt16(this.columns.Value);
            set => this.columns.Value = value;
        }

        [Category("Buttons")]
        public event EventHandler automaticButton_Click
        {
            add { automaticButton.Click += value; }
            remove { automaticButton.Click -= value; }
        }

        [Category("Buttons")]
        public event EventHandler manualButton_Click
        {
            add { manualButton.Click += value; }
            remove { manualButton.Click -= value; }
        }
    }
}
