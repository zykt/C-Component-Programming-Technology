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
    public partial class Form1 : Form
    {
        private enum Arithmetic
        {
            Sum,
            Sub,
            Mul,
            Div,
            Mod,
            None
        }

        private enum Library
        {
            Abs,
            Arccos,
            Arctg,
            Cos,
            Tg,
            Exp,
            Pi,
            Ln,
            Log,
            Round,
            Sqrt,
            None
        }

        private Arithmetic ArithmeticAction { get; set; }
        private Library LibraryAction { get; set; }

        public Form1()
        {
            InitializeComponent();
            this.ArithmeticAction = Arithmetic.None;
            this.LibraryAction = Library.None;
        }

        private Double? calculateArithmetic(Double arg1, Double arg2, Arithmetic action)
        {
            switch (this.ArithmeticAction)
            {
                case Arithmetic.Sum: return arg1 + arg2;
                case Arithmetic.Sub: return arg1 - arg2;
                case Arithmetic.Mul: return arg1 * arg2;
                case Arithmetic.Div: return arg1 / arg2;
                case Arithmetic.Mod: return arg1 % arg2;
                default: return null;
            }
        }

        private int? findIllegalChar(String s)
        {
            foreach (var it in s.Select((c, i) => new { Ch = c, Ind = i }))
            {
                if (!Char.IsDigit(it.Ch) && it.Ch != '.' && it.Ch != '-')
                    return it.Ind;
            }
            return null;
        }

        private DialogResult fixStringDialog(String s)
        {
            String text = $"Error: {s} should be a valid number\nFix it?";
            String title = "Invalid number";
            return CustomDialog.Show(text, title, "Fix!", "Cancel");
        }

        private void arithmeticsCalculateButton_Click(object sender, EventArgs e)
        {
            bool parsedArg1 = Double.TryParse(this.arithmeticsArg1.Text, out double arg1);
            if (!parsedArg1)
            {
                int? i = findIllegalChar(this.arithmeticsArg1.Text);
                if (i.HasValue)
                {
                    DialogResult res = fixStringDialog(this.arithmeticsArg1.Text);
                    if (res == DialogResult.OK)
                    {
                        this.arithmeticsArg1.Select((int)i, 1);
                        this.arithmeticsArg1.Focus();
                    }
                    else
                    {
                        this.arithmeticsArg1.Text = "";
                    }
                }
            }

            bool parsedArg2 = Double.TryParse(this.arithmeticsArg2.Text, out double arg2);
            if (!parsedArg2)
            {
                int? i = findIllegalChar(this.arithmeticsArg2.Text);
                if (i.HasValue)
                {
                    DialogResult res = fixStringDialog(this.arithmeticsArg2.Text);
                    if (res == DialogResult.OK)
                    {
                        this.arithmeticsArg2.Select((int)i, 1);
                        this.arithmeticsArg2.Focus();
                    }
                    else
                    {
                        this.arithmeticsArg2.Text = "";
                    }
                }
            }

            if (parsedArg1 && parsedArg2)
            {
                
                Double? result = calculateArithmetic(arg1, arg2, this.ArithmeticAction);
                if (result.HasValue)
                {
                    this.arithmeticsResultBox.Text = Convert.ToString(result);
                }
            }
        }

        private Double? calculateLibraryAction(Double arg, Library action)
        {
            switch (action)
            {
                case Library.Abs: return Math.Abs(arg);
                case Library.Arccos: return Math.Acos(arg);
                case Library.Arctg: return Math.Atan(arg);
                case Library.Cos: return Math.Cos(arg);
                case Library.Tg: return Math.Tan(arg);
                case Library.Pi: return Math.PI;
                case Library.Exp: return Math.Exp(arg);
                case Library.Ln: return Math.Log10(arg);
                case Library.Log: return Math.Log(arg);
                case Library.Round: return Math.Round(arg);
                case Library.Sqrt: return Math.Sqrt(arg);
                default: return null;
            }
        }

        private String validateArg(Double arg, Library action)
        {
            switch (action)
            {
                case Library.Arccos:
                    if (arg <= -1 || arg >= 1) return "a should be -1 <= a <= -1";
                    break;
                case Library.Ln:
                case Library.Log:
                case Library.Sqrt:
                    if (arg < 0) return "a can not be negative";
                    break;
            }
            return null;
        }

        private void libraryCalculateButton_Click(object sender, EventArgs e)
        {
            bool parsedArg = Double.TryParse(this.libraryArg.Text, out double arg);
            if (!parsedArg)
            {
                int? i = findIllegalChar(this.libraryArg.Text);
                if (i.HasValue)
                {
                    DialogResult res = fixStringDialog(this.libraryArg.Text);
                    if (res == DialogResult.OK)
                    {
                        this.libraryArg.Select((int)i, 1);
                        this.libraryArg.Focus();
                    }
                    else
                    {
                        this.libraryArg.Text = "";
                    }
                }
            } else
            {
                String error = validateArg(arg, this.LibraryAction);
                if (error == null)
                {
                    Double? result = calculateLibraryAction(arg, this.LibraryAction);
                    if (result.HasValue)
                    {
                        this.libraryResultBox.Text = Convert.ToString(result);
                    }
                } else
                {
                    this.libraryResultBox.Text = error;
                }                
            }
        }

        private void arithmeticsActionSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (arithmeticsActionSelector.SelectedIndex)
            {
                case 0: this.ArithmeticAction = Arithmetic.Sum; break;
                case 1: this.ArithmeticAction = Arithmetic.Sub; break;
                case 2: this.ArithmeticAction = Arithmetic.Mul; break;
                case 3: this.ArithmeticAction = Arithmetic.Div; break;
                case 4: this.ArithmeticAction = Arithmetic.Mod; break;
                default: this.ArithmeticAction = Arithmetic.None; break;
            }
        }

        private void libraryActionSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (libraryActionSelector.SelectedIndex)
            {
                case 0:  this.LibraryAction = Library.Abs; break; 
                case 1:  this.LibraryAction = Library.Arccos; break;
                case 2:  this.LibraryAction = Library.Arctg; break;
                case 3:  this.LibraryAction = Library.Cos; break;
                case 4:  this.LibraryAction = Library.Tg; break;
                case 5:  this.LibraryAction = Library.Exp; break;
                case 6:  this.LibraryAction = Library.Pi; break;
                case 7:  this.LibraryAction = Library.Ln; break;
                case 8:  this.LibraryAction = Library.Log; break;
                case 9:  this.LibraryAction = Library.Round; break;
                case 10: this.LibraryAction = Library.Sqrt; break;
                default: this.LibraryAction = Library.None; break;
            }
        }
    }
}