namespace Task4
{
    partial class Table
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TableGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TableGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TableGrid
            // 
            this.TableGrid.AllowUserToAddRows = false;
            this.TableGrid.AllowUserToDeleteRows = false;
            this.TableGrid.AllowUserToResizeColumns = false;
            this.TableGrid.AllowUserToResizeRows = false;
            this.TableGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TableGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableGrid.ColumnHeadersVisible = false;
            this.TableGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.TableGrid.Location = new System.Drawing.Point(0, 0);
            this.TableGrid.Name = "TableGrid";
            this.TableGrid.RowHeadersVisible = false;
            this.TableGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TableGrid.ShowEditingIcon = false;
            this.TableGrid.Size = new System.Drawing.Size(255, 255);
            this.TableGrid.TabIndex = 0;
            // 
            // Table
            // 
            this.Controls.Add(this.TableGrid);
            this.Name = "Table";
            this.Size = new System.Drawing.Size(255, 255);
            ((System.ComponentModel.ISupportInitialize)(this.TableGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView TableGrid;
    }
}
