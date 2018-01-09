using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class Table : UserControl
    {
        public Table()
        {
            InitializeComponent();
        }

        public Table(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public event DataGridViewCellEventHandler CellValueChanged
        {
            add => this.TableGrid.CellValueChanged += value;
            remove => this.TableGrid.CellValueChanged -= value;
        }

        [Category("Editing")]
        [DefaultValue(DataGridViewEditMode.EditOnKeystrokeOrF2)]
        public DataGridViewEditMode Editable
        {
            get => this.TableGrid.EditMode;
            set => this.TableGrid.EditMode = value;
        }

        public int Rows
        {
            get => this.TableGrid.RowCount;
            set => this.TableGrid.RowCount = value;
        }

        public int Columns
        {
            get => this.TableGrid.ColumnCount;
            set => this.TableGrid.ColumnCount = value;
        }

        public void UpdateFromArray<T>(T[,] array) => 
            this.TableGrid.UpdateFromArray(array);

        public void Clear() {
            foreach (DataGridViewRow row in this.TableGrid.Rows)
                foreach (DataGridViewCell cell in row.Cells)
                    cell.Value = null;

            this.TableGrid.Rows.Clear();
        }

        public object this[int row, int column]
        {
            get => this.TableGrid.Rows[row].Cells[column].Value;
        }
    }
}
