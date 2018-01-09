namespace Task2._2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.form2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form2Button = new System.Windows.Forms.ToolStripMenuItem();
            this.form3Button = new System.Windows.Forms.ToolStripMenuItem();
            this.childrenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form11Button = new System.Windows.Forms.ToolStripMenuItem();
            this.form12Button = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form2ToolStripMenuItem,
            this.childrenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(524, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // form2ToolStripMenuItem
            // 
            this.form2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form2Button,
            this.form3Button});
            this.form2ToolStripMenuItem.Name = "form2ToolStripMenuItem";
            this.form2ToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.form2ToolStripMenuItem.Text = "Independent Forms";
            // 
            // form2Button
            // 
            this.form2Button.Name = "form2Button";
            this.form2Button.Size = new System.Drawing.Size(103, 22);
            this.form2Button.Text = "Form2";
            this.form2Button.Click += new System.EventHandler(this.form2Button_Click);
            // 
            // form3Button
            // 
            this.form3Button.Name = "form3Button";
            this.form3Button.Size = new System.Drawing.Size(103, 22);
            this.form3Button.Text = "Form3";
            this.form3Button.Click += new System.EventHandler(this.form3Button_Click);
            // 
            // childrenToolStripMenuItem
            // 
            this.childrenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form11Button,
            this.form12Button});
            this.childrenToolStripMenuItem.Name = "childrenToolStripMenuItem";
            this.childrenToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.childrenToolStripMenuItem.Text = "Children";
            // 
            // form11Button
            // 
            this.form11Button.Name = "form11Button";
            this.form11Button.Size = new System.Drawing.Size(112, 22);
            this.form11Button.Text = "Form1.1";
            this.form11Button.Click += new System.EventHandler(this.form11Button_Click);
            // 
            // form12Button
            // 
            this.form12Button.Name = "form12Button";
            this.form12Button.Size = new System.Drawing.Size(112, 22);
            this.form12Button.Text = "Form1.2";
            this.form12Button.Click += new System.EventHandler(this.form12Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 401);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem form2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form2Button;
        private System.Windows.Forms.ToolStripMenuItem form3Button;
        private System.Windows.Forms.ToolStripMenuItem childrenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form11Button;
        private System.Windows.Forms.ToolStripMenuItem form12Button;
    }
}

