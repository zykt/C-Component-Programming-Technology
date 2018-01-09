namespace Task4
{
    partial class Input
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.automaticButton = new System.Windows.Forms.Button();
            this.manualButton = new System.Windows.Forms.Button();
            this.rows = new System.Windows.Forms.NumericUpDown();
            this.columns = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columns)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Matrix";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rows";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Columns";
            // 
            // automaticButton
            // 
            this.automaticButton.Location = new System.Drawing.Point(70, 185);
            this.automaticButton.Name = "automaticButton";
            this.automaticButton.Size = new System.Drawing.Size(75, 23);
            this.automaticButton.TabIndex = 5;
            this.automaticButton.Text = "Automatic";
            this.automaticButton.UseVisualStyleBackColor = true;
            // 
            // manualButton
            // 
            this.manualButton.Location = new System.Drawing.Point(164, 185);
            this.manualButton.Name = "manualButton";
            this.manualButton.Size = new System.Drawing.Size(75, 23);
            this.manualButton.TabIndex = 6;
            this.manualButton.Text = "Manual";
            this.manualButton.UseVisualStyleBackColor = true;
            // 
            // rows
            // 
            this.rows.Location = new System.Drawing.Point(37, 81);
            this.rows.Name = "rows";
            this.rows.Size = new System.Drawing.Size(32, 20);
            this.rows.TabIndex = 7;
            this.rows.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // columns
            // 
            this.columns.Location = new System.Drawing.Point(194, 81);
            this.columns.Name = "columns";
            this.columns.Size = new System.Drawing.Size(32, 20);
            this.columns.TabIndex = 8;
            this.columns.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Matrix creation method";
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.columns);
            this.Controls.Add(this.rows);
            this.Controls.Add(this.manualButton);
            this.Controls.Add(this.automaticButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Input";
            this.Size = new System.Drawing.Size(320, 237);
            ((System.ComponentModel.ISupportInitialize)(this.rows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button automaticButton;
        private System.Windows.Forms.Button manualButton;
        private System.Windows.Forms.NumericUpDown rows;
        private System.Windows.Forms.NumericUpDown columns;
        private System.Windows.Forms.Label label4;
    }
}
