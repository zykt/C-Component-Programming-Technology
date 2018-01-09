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
    public partial class Form1 : Form
    {
        private int[,] test = { { 1, 2, 3 }, { 4, 5, 6 } };

        public Form1()
        {
            InitializeComponent();
        }

        private void input1_automaticButton_Click(object sender, EventArgs e)
        {
            this.output1.Data = createRandom2DArray(this.input1.Rows, this.input1.Columns);
            this.input1.Hide();
            this.output1.Show();
        }

        private void input1_manualButton_Click(object sender, EventArgs e)
        {
            this.output1.Data = new int?[this.input1.Rows, this.input1.Columns];
            this.input1.Hide();
            this.output1.Show();
        }

        private void output1_calculateButton_Click(object sender, EventArgs e)
        {
            int nonzeroRows = 0;
            Boolean nonzero = true;

            for (int i = 0; i < this.output1.DataRows; i++)
            {
                nonzero = true;
                for (int j = 0; j < this.output1.DataColumns; j++)
                {
                    if ((this.output1.Data[i, j] ?? 0) == 0)
                        nonzero = false;
                }
                if (nonzero)
                    nonzeroRows += 1;
            }

            this.output1.outputText = $"Rows without zeros: {nonzeroRows}";
        }

        private void output1_cancelButton_Click(object sender, EventArgs e)
        {
            this.output1.outputText = "";
            this.output1.ClearData();
            this.output1.ClearResult();
            this.output1.Hide();
            this.input1.Show();
        }

        private void output1_clearButton_Click(object sender, EventArgs e)
        {
            this.output1.ClearData();
        }

        private void input2_automaticButton_Click(object sender, EventArgs e)
        {
            this.output2.Data = createRandom2DArray(this.input2.Rows, this.input2.Columns);
            this.input2.Hide();
            this.output2.Show();
        }

        private void input2_manualButton_Click(object sender, EventArgs e)
        {
            this.output2.Data = new int?[this.input2.Rows, this.input2.Columns];
            this.input2.Hide();
            this.output2.Show();
        }

        private void output2_calculateButton_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int[,] newData = new int[this.output2.DataRows, this.output2.DataColumns];
            int col1 = r.Next(this.output2.DataColumns);
            int col2;

            do
            {
                col2 = r.Next(this.output2.DataColumns);
            } while (col1 == col2);

            for (int i = 0; i < this.output2.DataRows; i++)
            {
                for (int j = 0; j < this.output2.DataColumns; j++)
                {
                    if (j != col1 && j != col2)
                    {
                        newData[i, j] = this.output2.Data[i, j] ?? 0;
                    } else if (j == col1)
                    {
                        newData[i, col2] = this.output2.Data[i, col1] ?? 0;
                    } else if (j == col2)
                    {
                        newData[i, col1] = this.output2.Data[i, col2] ?? 0;
                    }
                }
            }

            this.output2.Result = newData;
        }
        
        private void output2_clearButton_Click(object sender, EventArgs e)
        {
            this.output2.ClearData();
        }

        private void output2_cancelButton_Click(object sender, EventArgs e)
        {
            this.output2.ClearData();
            this.output2.ClearResult();
            this.output2.Hide();
            this.input2.Show();
        }

        private static int?[,] createRandom2DArray(int rows, int columns)
        {
            int?[,] array = new int?[rows, columns];
            Random r = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = r.Next(10);
                }
            }

            return array;
        }
    }

}
