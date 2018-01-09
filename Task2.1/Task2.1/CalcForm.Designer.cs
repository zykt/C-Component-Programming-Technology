namespace Task2._1
{
    partial class CalcForm
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
            this.number1Box = new System.Windows.Forms.MaskedTextBox();
            this.number2Box = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.powRadio = new System.Windows.Forms.RadioButton();
            this.divRadio = new System.Windows.Forms.RadioButton();
            this.multRadio = new System.Windows.Forms.RadioButton();
            this.minusRadio = new System.Windows.Forms.RadioButton();
            this.plusRadio = new System.Windows.Forms.RadioButton();
            this.Number1Label = new System.Windows.Forms.Label();
            this.Number2Label = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // number1Box
            // 
            this.number1Box.Location = new System.Drawing.Point(12, 55);
            this.number1Box.Mask = "00000";
            this.number1Box.Name = "number1Box";
            this.number1Box.Size = new System.Drawing.Size(100, 20);
            this.number1Box.TabIndex = 0;
            this.number1Box.ValidatingType = typeof(int);
            // 
            // number2Box
            // 
            this.number2Box.Location = new System.Drawing.Point(283, 55);
            this.number2Box.Mask = "00000";
            this.number2Box.Name = "number2Box";
            this.number2Box.Size = new System.Drawing.Size(100, 20);
            this.number2Box.TabIndex = 1;
            this.number2Box.ValidatingType = typeof(int);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.powRadio);
            this.groupBox1.Controls.Add(this.divRadio);
            this.groupBox1.Controls.Add(this.multRadio);
            this.groupBox1.Controls.Add(this.minusRadio);
            this.groupBox1.Controls.Add(this.plusRadio);
            this.groupBox1.Location = new System.Drawing.Point(168, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(49, 143);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // powRadio
            // 
            this.powRadio.AutoSize = true;
            this.powRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.powRadio.Location = new System.Drawing.Point(9, 109);
            this.powRadio.Name = "powRadio";
            this.powRadio.Size = new System.Drawing.Size(34, 24);
            this.powRadio.TabIndex = 1;
            this.powRadio.Text = "^";
            this.powRadio.UseVisualStyleBackColor = true;
            // 
            // divRadio
            // 
            this.divRadio.AutoSize = true;
            this.divRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divRadio.Location = new System.Drawing.Point(10, 86);
            this.divRadio.Name = "divRadio";
            this.divRadio.Size = new System.Drawing.Size(31, 24);
            this.divRadio.TabIndex = 0;
            this.divRadio.Text = "/";
            this.divRadio.UseVisualStyleBackColor = true;
            // 
            // multRadio
            // 
            this.multRadio.AutoSize = true;
            this.multRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multRadio.Location = new System.Drawing.Point(10, 63);
            this.multRadio.Name = "multRadio";
            this.multRadio.Size = new System.Drawing.Size(33, 24);
            this.multRadio.TabIndex = 0;
            this.multRadio.Text = "*";
            this.multRadio.UseVisualStyleBackColor = true;
            // 
            // minusRadio
            // 
            this.minusRadio.AutoSize = true;
            this.minusRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minusRadio.Location = new System.Drawing.Point(10, 40);
            this.minusRadio.Name = "minusRadio";
            this.minusRadio.Size = new System.Drawing.Size(32, 24);
            this.minusRadio.TabIndex = 0;
            this.minusRadio.Text = "-";
            this.minusRadio.UseVisualStyleBackColor = true;
            // 
            // plusRadio
            // 
            this.plusRadio.AutoSize = true;
            this.plusRadio.Checked = true;
            this.plusRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusRadio.Location = new System.Drawing.Point(10, 17);
            this.plusRadio.Name = "plusRadio";
            this.plusRadio.Size = new System.Drawing.Size(36, 24);
            this.plusRadio.TabIndex = 0;
            this.plusRadio.TabStop = true;
            this.plusRadio.Text = "+";
            this.plusRadio.UseVisualStyleBackColor = true;
            // 
            // Number1Label
            // 
            this.Number1Label.AutoSize = true;
            this.Number1Label.Location = new System.Drawing.Point(12, 9);
            this.Number1Label.Name = "Number1Label";
            this.Number1Label.Size = new System.Drawing.Size(39, 13);
            this.Number1Label.TabIndex = 3;
            this.Number1Label.Text = "Число";
            // 
            // Number2Label
            // 
            this.Number2Label.AutoSize = true;
            this.Number2Label.Location = new System.Drawing.Point(283, 9);
            this.Number2Label.Name = "Number2Label";
            this.Number2Label.Size = new System.Drawing.Size(39, 13);
            this.Number2Label.TabIndex = 4;
            this.Number2Label.Text = "Число";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(12, 118);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(283, 121);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(283, 213);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(116, 69);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(12, 213);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 8;
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 294);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.Number2Label);
            this.Controls.Add(this.Number1Label);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.number2Box);
            this.Controls.Add(this.number1Box);
            this.Name = "CalcForm";
            this.Text = "Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox number1Box;
        private System.Windows.Forms.MaskedTextBox number2Box;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton powRadio;
        private System.Windows.Forms.RadioButton divRadio;
        private System.Windows.Forms.RadioButton multRadio;
        private System.Windows.Forms.RadioButton minusRadio;
        private System.Windows.Forms.RadioButton plusRadio;
        private System.Windows.Forms.Label Number1Label;
        private System.Windows.Forms.Label Number2Label;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label resultLabel;
    }
}