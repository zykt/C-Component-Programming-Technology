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
    public partial class CalcForm : Form
    {
        enum Op
        {
            Plus,
            Minus,
            Mult,
            Div,
            Pow,
            NoOp //should never reach this
        };

        private Op readOp() {
            if (plusRadio.Checked)
                return Op.Plus;
            if (minusRadio.Checked)
                return Op.Minus;
            if (multRadio.Checked)
                return Op.Mult;
            if (divRadio.Checked)
                return Op.Div;
            if (powRadio.Checked)
                return Op.Pow;
            return Op.NoOp;
        }

        public CalcForm()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            number1Box.Clear();
            number2Box.Clear();
            plusRadio.Checked = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.Exit();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(number1Box.Text);
                double num2 = double.Parse(number2Box.Text);
                Op op = readOp();
                double result;
                switch (op)
                {
                    case Op.Plus:  result = num1 + num2; break;
                    case Op.Minus: result = num1 - num2; break;
                    case Op.Mult:  result = num1 * num2; break;
                    case Op.Div:   result = num1 / num2; break;
                    case Op.Pow:   result = Math.Pow(num1, num2); break;
                    default:       throw new System.Exception("No op selected");
                }
                resultLabel.Text = result.ToString();
            }
            catch (Exception exception) 
            {
                resultLabel.Text = "Something went wrong\n" + exception.ToString();
            }
        }
    }
}
