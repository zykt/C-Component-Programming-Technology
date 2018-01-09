namespace Task3
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
            this.label1 = new System.Windows.Forms.Label();
            this.arithmeticsArg1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.arithmeticsArg2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.arithmeticsResultBox = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.arithmeticsCalculateButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.arithmeticsActionSelector = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.libraryCalculateButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.libraryActionSelector = new System.Windows.Forms.ComboBox();
            this.libraryResultBox = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.libraryArg = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Math";
            // 
            // arithmeticsArg1
            // 
            this.arithmeticsArg1.Location = new System.Drawing.Point(16, 33);
            this.arithmeticsArg1.Name = "arithmeticsArg1";
            this.arithmeticsArg1.Size = new System.Drawing.Size(100, 20);
            this.arithmeticsArg1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "b";
            // 
            // arithmeticsArg2
            // 
            this.arithmeticsArg2.Location = new System.Drawing.Point(16, 72);
            this.arithmeticsArg2.Name = "arithmeticsArg2";
            this.arithmeticsArg2.Size = new System.Drawing.Size(100, 20);
            this.arithmeticsArg2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "result";
            // 
            // arithmeticsResultBox
            // 
            this.arithmeticsResultBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arithmeticsResultBox.Location = new System.Drawing.Point(16, 108);
            this.arithmeticsResultBox.Name = "arithmeticsResultBox";
            this.arithmeticsResultBox.Size = new System.Drawing.Size(227, 20);
            this.arithmeticsResultBox.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.arithmeticsCalculateButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.arithmeticsActionSelector);
            this.groupBox1.Controls.Add(this.arithmeticsResultBox);
            this.groupBox1.Controls.Add(this.arithmeticsArg2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.arithmeticsArg1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(16, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 141);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arithmetics";
            // 
            // arithmeticsCalculateButton
            // 
            this.arithmeticsCalculateButton.Location = new System.Drawing.Point(122, 56);
            this.arithmeticsCalculateButton.Name = "arithmeticsCalculateButton";
            this.arithmeticsCalculateButton.Size = new System.Drawing.Size(121, 23);
            this.arithmeticsCalculateButton.TabIndex = 8;
            this.arithmeticsCalculateButton.Text = "calculate";
            this.arithmeticsCalculateButton.UseVisualStyleBackColor = true;
            this.arithmeticsCalculateButton.Click += new System.EventHandler(this.arithmeticsCalculateButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "action";
            // 
            // arithmeticsActionSelector
            // 
            this.arithmeticsActionSelector.FormattingEnabled = true;
            this.arithmeticsActionSelector.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "%"});
            this.arithmeticsActionSelector.Location = new System.Drawing.Point(122, 33);
            this.arithmeticsActionSelector.Name = "arithmeticsActionSelector";
            this.arithmeticsActionSelector.Size = new System.Drawing.Size(121, 21);
            this.arithmeticsActionSelector.TabIndex = 6;
            this.arithmeticsActionSelector.SelectedIndexChanged += new System.EventHandler(this.arithmeticsActionSelector_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.libraryCalculateButton);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.libraryActionSelector);
            this.groupBox2.Controls.Add(this.libraryResultBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.libraryArg);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(272, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 141);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Library";
            // 
            // libraryCalculateButton
            // 
            this.libraryCalculateButton.Location = new System.Drawing.Point(122, 56);
            this.libraryCalculateButton.Name = "libraryCalculateButton";
            this.libraryCalculateButton.Size = new System.Drawing.Size(121, 23);
            this.libraryCalculateButton.TabIndex = 8;
            this.libraryCalculateButton.Text = "calculate";
            this.libraryCalculateButton.UseVisualStyleBackColor = true;
            this.libraryCalculateButton.Click += new System.EventHandler(this.libraryCalculateButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "action";
            // 
            // libraryActionSelector
            // 
            this.libraryActionSelector.FormattingEnabled = true;
            this.libraryActionSelector.Items.AddRange(new object[] {
            "abs",
            "arccos",
            "arctg",
            "cos",
            "tg",
            "exp",
            "pi",
            "lg",
            "log",
            "round",
            "sqrt"});
            this.libraryActionSelector.Location = new System.Drawing.Point(122, 33);
            this.libraryActionSelector.Name = "libraryActionSelector";
            this.libraryActionSelector.Size = new System.Drawing.Size(121, 21);
            this.libraryActionSelector.TabIndex = 6;
            this.libraryActionSelector.SelectedIndexChanged += new System.EventHandler(this.libraryActionSelector_SelectedIndexChanged);
            // 
            // libraryResultBox
            // 
            this.libraryResultBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.libraryResultBox.Location = new System.Drawing.Point(16, 108);
            this.libraryResultBox.Name = "libraryResultBox";
            this.libraryResultBox.Size = new System.Drawing.Size(227, 20);
            this.libraryResultBox.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "result";
            // 
            // libraryArg
            // 
            this.libraryArg.Location = new System.Drawing.Point(16, 33);
            this.libraryArg.Name = "libraryArg";
            this.libraryArg.Size = new System.Drawing.Size(100, 20);
            this.libraryArg.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "a";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 200);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MathForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox arithmeticsArg1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox arithmeticsArg2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label arithmeticsResultBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button arithmeticsCalculateButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox arithmeticsActionSelector;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button libraryCalculateButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox libraryActionSelector;
        private System.Windows.Forms.Label libraryResultBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox libraryArg;
        private System.Windows.Forms.Label label9;
    }
}

