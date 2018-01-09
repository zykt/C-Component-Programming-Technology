namespace Task4
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.input1 = new Task4.Input();
            this.output1 = new Task4.Output();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.input2 = new Task4.Input();
            this.output2 = new Task4.Output();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(346, 277);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.input1);
            this.tabPage1.Controls.Add(this.output1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(338, 251);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Subtask 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // input1
            // 
            this.input1.Columns = 3;
            this.input1.Location = new System.Drawing.Point(6, 6);
            this.input1.Name = "input1";
            this.input1.Rows = 3;
            this.input1.Size = new System.Drawing.Size(320, 237);
            this.input1.TabIndex = 4;
            this.input1.automaticButton_Click += new System.EventHandler(this.input1_automaticButton_Click);
            this.input1.manualButton_Click += new System.EventHandler(this.input1_manualButton_Click);
            // 
            // output1
            // 
            this.output1.Data = null;
            this.output1.DataColumns = 0;
            this.output1.DataRows = 0;
            this.output1.Location = new System.Drawing.Point(6, 6);
            this.output1.Name = "output1";
            this.output1.outputText = "";
            this.output1.Result = null;
            this.output1.Size = new System.Drawing.Size(320, 237);
            this.output1.TabIndex = 3;
            this.output1.Visible = false;
            this.output1.calculateButton_Click += new System.EventHandler(this.output1_calculateButton_Click);
            this.output1.clearButton_Click += new System.EventHandler(this.output1_clearButton_Click);
            this.output1.cancelButton_Click += new System.EventHandler(this.output1_cancelButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.input2);
            this.tabPage2.Controls.Add(this.output2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(338, 251);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Subtask 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // input2
            // 
            this.input2.Columns = 3;
            this.input2.Location = new System.Drawing.Point(6, 6);
            this.input2.Name = "input2";
            this.input2.Rows = 3;
            this.input2.Size = new System.Drawing.Size(320, 237);
            this.input2.TabIndex = 0;
            this.input2.automaticButton_Click += new System.EventHandler(this.input2_automaticButton_Click);
            this.input2.manualButton_Click += new System.EventHandler(this.input2_manualButton_Click);
            // 
            // output2
            // 
            this.output2.Data = null;
            this.output2.DataColumns = 0;
            this.output2.DataRows = 0;
            this.output2.Location = new System.Drawing.Point(6, 6);
            this.output2.Name = "output2";
            this.output2.outputText = "";
            this.output2.Result = null;
            this.output2.Size = new System.Drawing.Size(320, 237);
            this.output2.TabIndex = 1;
            this.output2.Visible = false;
            this.output2.calculateButton_Click += new System.EventHandler(this.output2_calculateButton_Click);
            this.output2.clearButton_Click += new System.EventHandler(this.output2_clearButton_Click);
            this.output2.cancelButton_Click += new System.EventHandler(this.output2_cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(146, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arrays";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(370, 353);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Input input2;
        private Output output1;
        private Output output2;
        private Input input1;
        private System.Windows.Forms.Label label1;
    }
}

