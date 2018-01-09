namespace Task4
{
    partial class Output
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.resultTable = new Task4.Table(this.components);
            this.dataTable = new Task4.Table(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Result";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(33, 166);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(80, 23);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(207, 166);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(80, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(120, 200);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(100, 4);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 7;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultTable
            // 
            this.resultTable.Columns = 0;
            this.resultTable.Editable = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.resultTable.Location = new System.Drawing.Point(177, 20);
            this.resultTable.Name = "resultTable";
            this.resultTable.Rows = 0;
            this.resultTable.Size = new System.Drawing.Size(140, 140);
            this.resultTable.TabIndex = 3;
            // 
            // dataTable
            // 
            this.dataTable.BackColor = System.Drawing.SystemColors.Control;
            this.dataTable.Columns = 0;
            this.dataTable.Editable = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataTable.Location = new System.Drawing.Point(3, 20);
            this.dataTable.Name = "dataTable";
            this.dataTable.Rows = 0;
            this.dataTable.Size = new System.Drawing.Size(140, 140);
            this.dataTable.TabIndex = 0;
            this.dataTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTable_CellValueChanged);
            // 
            // Output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resultTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataTable);
            this.Name = "Output";
            this.Size = new System.Drawing.Size(320, 237);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Table dataTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Table resultTable;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label outputLabel;
    }
}
