using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public static class dataGridViewExtensions
    {
        public static void UpdateFromArray<T>(this DataGridView grid, T[,] array)
        {

            grid.RowCount = array?.GetLength(0) ?? 0;
            grid.ColumnCount = array?.GetLength(1) ?? 0;

            for (int i = 0; i < grid.RowCount; i++)
            {
                for (int j = 0; j < grid.ColumnCount; j++)
                {
                    grid.Rows[i].Cells[j].Value = array[i, j];
                }
            }
        }
    }
}
