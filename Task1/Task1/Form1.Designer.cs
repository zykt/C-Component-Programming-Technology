namespace Task1
{
    partial class Task1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task1));
            this.label = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.hobbyLabel = new System.Windows.Forms.Label();
            this.genderGroupBox = new System.Windows.Forms.GroupBox();
            this.femaleCheckBox = new System.Windows.Forms.RadioButton();
            this.maleCheckBox = new System.Windows.Forms.RadioButton();
            this.musicCheckBox = new System.Windows.Forms.CheckBox();
            this.sportCheckBox = new System.Windows.Forms.CheckBox();
            this.scienceCheckBox = new System.Windows.Forms.CheckBox();
            this.artCheckBox = new System.Windows.Forms.CheckBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.genderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(6, 13);
            this.label.Name = "label";
            this.label.Padding = new System.Windows.Forms.Padding(5);
            this.label.Size = new System.Drawing.Size(275, 41);
            this.label.TabIndex = 0;
            this.label.Text = "Введите ваши данные";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(12, 87);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(109, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Введите имя";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genderLabel.Location = new System.Drawing.Point(11, 162);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(106, 20);
            this.genderLabel.TabIndex = 0;
            this.genderLabel.Text = "Укажите пол";
            // 
            // hobbyLabel
            // 
            this.hobbyLabel.AutoSize = true;
            this.hobbyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hobbyLabel.Location = new System.Drawing.Point(13, 239);
            this.hobbyLabel.Name = "hobbyLabel";
            this.hobbyLabel.Size = new System.Drawing.Size(135, 20);
            this.hobbyLabel.TabIndex = 0;
            this.hobbyLabel.Text = "Ваши увлечения";
            // 
            // genderGroupBox
            // 
            this.genderGroupBox.Controls.Add(this.maleCheckBox);
            this.genderGroupBox.Controls.Add(this.femaleCheckBox);
            this.genderGroupBox.Location = new System.Drawing.Point(149, 131);
            this.genderGroupBox.Name = "genderGroupBox";
            this.genderGroupBox.Size = new System.Drawing.Size(100, 82);
            this.genderGroupBox.TabIndex = 1;
            this.genderGroupBox.TabStop = false;
            // 
            // femaleCheckBox
            // 
            this.femaleCheckBox.AutoSize = true;
            this.femaleCheckBox.Checked = true;
            this.femaleCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.femaleCheckBox.Location = new System.Drawing.Point(7, 20);
            this.femaleCheckBox.Name = "femaleCheckBox";
            this.femaleCheckBox.Size = new System.Drawing.Size(40, 24);
            this.femaleCheckBox.TabIndex = 0;
            this.femaleCheckBox.TabStop = true;
            this.femaleCheckBox.Text = "Ж";
            this.femaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // maleCheckBox
            // 
            this.maleCheckBox.AutoSize = true;
            this.maleCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maleCheckBox.Location = new System.Drawing.Point(7, 44);
            this.maleCheckBox.Name = "maleCheckBox";
            this.maleCheckBox.Size = new System.Drawing.Size(40, 24);
            this.maleCheckBox.TabIndex = 1;
            this.maleCheckBox.Text = "М";
            this.maleCheckBox.UseVisualStyleBackColor = true;
            // 
            // musicCheckBox
            // 
            this.musicCheckBox.AutoSize = true;
            this.musicCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.musicCheckBox.Location = new System.Drawing.Point(28, 280);
            this.musicCheckBox.Name = "musicCheckBox";
            this.musicCheckBox.Size = new System.Drawing.Size(84, 24);
            this.musicCheckBox.TabIndex = 2;
            this.musicCheckBox.Text = "Музыка";
            this.musicCheckBox.UseVisualStyleBackColor = true;
            // 
            // sportCheckBox
            // 
            this.sportCheckBox.AutoSize = true;
            this.sportCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sportCheckBox.Location = new System.Drawing.Point(28, 303);
            this.sportCheckBox.Name = "sportCheckBox";
            this.sportCheckBox.Size = new System.Drawing.Size(75, 24);
            this.sportCheckBox.TabIndex = 2;
            this.sportCheckBox.Text = "Спорт";
            this.sportCheckBox.UseVisualStyleBackColor = true;
            // 
            // scienceCheckBox
            // 
            this.scienceCheckBox.AutoSize = true;
            this.scienceCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scienceCheckBox.Location = new System.Drawing.Point(118, 280);
            this.scienceCheckBox.Name = "scienceCheckBox";
            this.scienceCheckBox.Size = new System.Drawing.Size(73, 24);
            this.scienceCheckBox.TabIndex = 2;
            this.scienceCheckBox.Text = "Наука";
            this.scienceCheckBox.UseVisualStyleBackColor = true;
            // 
            // artCheckBox
            // 
            this.artCheckBox.AutoSize = true;
            this.artCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.artCheckBox.Location = new System.Drawing.Point(118, 303);
            this.artCheckBox.Name = "artCheckBox";
            this.artCheckBox.Size = new System.Drawing.Size(103, 24);
            this.artCheckBox.TabIndex = 2;
            this.artCheckBox.Text = "Живопись";
            this.artCheckBox.UseVisualStyleBackColor = true;
            // 
            // enterButton
            // 
            this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterButton.Location = new System.Drawing.Point(9, 410);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(95, 31);
            this.enterButton.TabIndex = 3;
            this.enterButton.Text = "Ввести";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(114, 410);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(95, 31);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(287, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 428);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBox.Location = new System.Drawing.Point(149, 84);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 26);
            this.nameBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(304, 35);
            this.label1.MaximumSize = new System.Drawing.Size(300, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 7;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(305, 41);
            this.outputLabel.MaximumSize = new System.Drawing.Size(300, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 8;
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.artCheckBox);
            this.Controls.Add(this.scienceCheckBox);
            this.Controls.Add(this.sportCheckBox);
            this.Controls.Add(this.musicCheckBox);
            this.Controls.Add(this.genderGroupBox);
            this.Controls.Add(this.hobbyLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Task1";
            this.Text = "Task1";
            this.genderGroupBox.ResumeLayout(false);
            this.genderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label hobbyLabel;
        private System.Windows.Forms.GroupBox genderGroupBox;
        private System.Windows.Forms.RadioButton maleCheckBox;
        private System.Windows.Forms.RadioButton femaleCheckBox;
        private System.Windows.Forms.CheckBox musicCheckBox;
        private System.Windows.Forms.CheckBox sportCheckBox;
        private System.Windows.Forms.CheckBox scienceCheckBox;
        private System.Windows.Forms.CheckBox artCheckBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label outputLabel;
    }
}

