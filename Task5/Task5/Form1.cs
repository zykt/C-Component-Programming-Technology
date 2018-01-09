using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Task4
{
    public partial class Form1 : Form
    {
        private int[,] test = { { 1, 2, 3 }, { 4, 5, 6 } };

        private Browser BrowserForm;

        public Form1()
        {
            InitializeComponent();

            this.OpenFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            this.SaveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
        }

        private void Calculate1()
        {
            int nonzeroRows = 0;
            Boolean nonzero = true;

            for (int i = 0; i < this.Output1.DataRows; i++)
            {
                nonzero = true;
                for (int j = 0; j < this.Output1.DataColumns; j++)
                {
                    if ((this.Output1.Data[i, j] ?? 0) == 0)
                        nonzero = false;
                }
                if (nonzero)
                    nonzeroRows += 1;
            }

            this.Output1.outputText = $"Rows without zeros: {nonzeroRows}";
            this.Output1.Result = this.Output1.Data.ConvertElementsFromNullable();
        }

        private void Calculate2()
        {
            if (this.Output2.DataColumns < 2) return;

            Random r = new Random();
            int[,] newData = new int[this.Output2.DataRows, this.Output2.DataColumns];
            int col1 = r.Next(this.Output2.DataColumns);
            int col2;

            do
            {
                col2 = r.Next(this.Output2.DataColumns);
            } while (col1 == col2);

            for (int i = 0; i < this.Output2.DataRows; i++)
            {
                for (int j = 0; j < this.Output2.DataColumns; j++)
                {
                    if (j != col1 && j != col2)
                    {
                        newData[i, j] = this.Output2.Data[i, j] ?? 0;
                    }
                    else if (j == col1)
                    {
                        newData[i, col2] = this.Output2.Data[i, col1] ?? 0;
                    }
                    else if (j == col2)
                    {
                        newData[i, col1] = this.Output2.Data[i, col2] ?? 0;
                    }
                }
            }

            this.Output2.Result = newData;
        }

        private void OpenData()
        {
            String content = this.OpenFileDialog();
            if (content != null)
            {
                int[,] matrix = Matrix.FromString(content);
                this.LoadMatrix(matrix);
            }
        }

        private void SaveResult()
        {
            int[,] matrix = null;

            switch (this.tabControl1.SelectedIndex)
            {
                case 0:
                    if (this.Output1.Visible && this.Output1.Result != null)
                        matrix = this.Output1.Result;
                    break;
                case 1:
                    if (this.Output2.Visible && this.Output2.Result != null)
                        matrix = this.Output2.Result;
                    break;
            }

            if (matrix != null)
                this.SaveFileDialog(Matrix.ToString(matrix));
        }

        private String OpenFileDialog()
        {
            if (this.OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader f = new StreamReader(this.OpenFileDialog1.FileName))
                {
                    return f.ReadToEnd();
                }
            }
            return null;
        }

        private void SaveFileDialog(String content)
        {
            if (this.SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter f = new StreamWriter(this.SaveFileDialog1.FileName))
                {
                    f.Write(content);
                }
            }
        }

        private void LoadMatrix(int[,] matrix)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    this.Output1.Data = matrix.ConvertElementsToNullable();
                    if (!this.Output1.Visible)
                    {
                        this.Input1.Hide();
                        this.Output1.Show();
                    }
                    break;
                case 1:
                    this.Output2.Data = matrix.ConvertElementsToNullable();
                    if (!this.Output2.Visible)
                    {
                        this.Input2.Hide();
                        this.Output2.Show();
                    }
                    break;
            }
        }

        /* 
        ** Event handlers **
        */

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.TimeStatusLabel.Text = DateTime.Now.ToLongTimeString();
            this.DateStatusLabel.Text = DateTime.Now.ToLongDateString();
        }

        private void Input1_automaticButton_Click(object sender, EventArgs e)
        {
            this.Output1.Data = Matrix.CreateRandom2DArray(this.Input1.Rows, this.Input1.Columns).ConvertElementsToNullable();
            this.Input1.Hide();
            this.Output1.Show();
        }

        private void Input1_manualButton_Click(object sender, EventArgs e)
        {
            this.Output1.Data = new int?[this.Input1.Rows, this.Input1.Columns];
            this.Input1.Hide();
            this.Output1.Show();
        }

        private void Output1_calculateButton_Click(object sender, EventArgs e)
        {
            Calculate1();
        }

        private void Output1_cancelButton_Click(object sender, EventArgs e)
        {
            this.Output1.Clear();
            this.Output1.Hide();
            this.Input1.Show();
        }

        private void Output1_clearButton_Click(object sender, EventArgs e)
        {
            this.Output1.Clear();
        }

        private void Input2_automaticButton_Click(object sender, EventArgs e)
        {
            this.Output2.Data = Matrix.CreateRandom2DArray(this.Input2.Rows, this.Input2.Columns).ConvertElementsToNullable();
            this.Input2.Hide();
            this.Output2.Show();
        }

        private void Input2_manualButton_Click(object sender, EventArgs e)
        {
            this.Output2.Data = new int?[this.Input2.Rows, this.Input2.Columns];
            this.Input2.Hide();
            this.Output2.Show();
        }

        private void Output2_calculateButton_Click(object sender, EventArgs e)
        {
            this.Calculate2();
        }
        
        private void Output2_clearButton_Click(object sender, EventArgs e)
        {
            this.Output2.Clear();
        }

        private void Output2_cancelButton_Click(object sender, EventArgs e)
        {
            this.Output2.Clear();
            this.Output2.Hide();
            this.Input2.Show();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenData();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveResult();
        }

        private void CalculateStripButton_Click(object sender, EventArgs e)
        {
            switch (this.tabControl1.SelectedIndex)
            {
                case 0:
                    if (this.Output1.Visible)
                        Calculate1();
                    break;
                case 1:
                    if (this.Output2.Visible)
                        Calculate2();
                    break;
            }
        }

        private void OpenStripButton_Click(object sender, EventArgs e)
        {
            this.OpenData();
        }

        private void SaveStripButton_Click(object sender, EventArgs e)
        {
            this.SaveResult();
        }

        private void CalculateStripButton_MouseEnter(object sender, EventArgs e)
        {
            this.InfoStatusLabel.Text = "Calculate";
        }

        private void OpenStripButton_MouseEnter(object sender, EventArgs e)
        {
            this.InfoStatusLabel.Text = "Open";
        }

        private void SaveStripButton_MouseEnter(object sender, EventArgs e)
        {
            this.InfoStatusLabel.Text = "Save";
        }

        private void TimeStatusLabel_MouseEnter(object sender, EventArgs e)
        {
            this.InfoStatusLabel.Text = "Time";
        }

        private void DateStatusLabel_MouseEnter(object sender, EventArgs e)
        {
            this.InfoStatusLabel.Text = "Date";
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowserForm = new Browser();
            this.BrowserForm.Path = Path.Combine(Environment.CurrentDirectory, "about.html");
            this.BrowserForm.Show();
        }

        private void KeyboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowserForm = new Browser();
            this.BrowserForm.Path = Path.Combine(Environment.CurrentDirectory, "keyboard.html");
            this.BrowserForm.Show();
        }

        private void MatricesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowserForm = new Browser();
            this.BrowserForm.Path = Path.Combine(Environment.CurrentDirectory, "matrices.html");
            this.BrowserForm.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // this.InfoStatusLabel.Text = $"Got key {e.KeyCode}";
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Add)
            {
                switch (tabControl1.SelectedIndex)
                {
                    case 0:
                        if (Output1.Visible && Output1.Result != null)
                        {
                            this.Output1.Result = Matrix.Add(this.Output1.Data.ConvertElementsFromNullable(),
                                                             this.Output1.Result);
                            this.InfoStatusLabel.Text = "Preforming addition";
                        }
                        break;
                    case 1:
                        if (Output2.Visible && Output2.Result != null)
                        {
                            this.Output2.Result = Matrix.Add(this.Output2.Data.ConvertElementsFromNullable(),
                                                             this.Output2.Result);
                            this.InfoStatusLabel.Text = "Preforming addition";
                        }
                        break;
                }
            } else if (e.KeyCode == Keys.Escape)
            {
                switch (tabControl1.SelectedIndex)
                {
                    case 0:
                        if (Output1.Visible)
                        {
                            this.Output1.Clear();
                            this.InfoStatusLabel.Text = "Clearing..";
                        }
                        break;
                    case 1:
                        if (Output2.Visible)
                        {
                            this.Output2.Clear();
                            this.InfoStatusLabel.Text = "Clearing..";
                        }
                        break;
                }
            }
        }

    }
}
