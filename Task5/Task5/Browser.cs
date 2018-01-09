using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();
        }

        private String _path;

        public String Path
        {
            get { return this._path; }
            set { this.Web.Navigate(value); this._path = value; }
        }
    }
}
