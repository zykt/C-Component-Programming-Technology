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
    public partial class Output : UserControl
    {
        public Output()
        {
            InitializeComponent();
        }

        [Category("Buttons")]
        public event EventHandler calculateButton_Click
        {
            add { calculateButton.Click += value; }
            remove { calculateButton.Click -= value; }
        }

        [Category("Buttons")]
        public event EventHandler clearButton_Click
        {
            add { clearButton.Click += value; }
            remove { clearButton.Click -= value; }
        }

        [Category("Buttons")]
        public event EventHandler cancelButton_Click
        {
            add { cancelButton.Click += value; }
            remove { cancelButton.Click -= value; }
        }

        //public event DataGridViewCellEventHandler dataTable_CellValueChanged
        //{
        //    add => this.dataTable.CellValueChanged += value;
        //    remove => this.dataTable.CellValueChanged -= value;
        //}

        private int?[,] _data;
        private int[,] _result;

        public int?[,] Data
        {
            get { return _data; }
            set { _data = value; this.dataTable.UpdateFromArray(value); }
        }

        public int[,] Result
        {
            get { return _result; }
            set { _result = value; this.resultTable.UpdateFromArray(value); }
        }

        public int DataRows
        {
            get => this.dataTable.Rows;
            set => this.dataTable.Rows = value;
        }

        public int DataColumns
        {
            get => this.dataTable.Columns;
            set => this.dataTable.Columns = value;
        }

        public String outputText
        {
            get => this.outputLabel.Text;
            set => this.outputLabel.Text = value;
        }

        public void Clear()
        { 
            this.outputText = "";
            this.ClearData();
            this.ClearResult();
        }

        public void ClearData() => 
            this.dataTable.Clear();

        public void ClearResult() =>
            this.Result = null;

        private void dataTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            object value = this.dataTable[e.RowIndex, e.ColumnIndex];
            if (value == null)
                this.Data[e.RowIndex, e.ColumnIndex] = null;
            else
                this.Data[e.RowIndex, e.ColumnIndex] = Convert.ToInt16(value);
        }
    }
}
