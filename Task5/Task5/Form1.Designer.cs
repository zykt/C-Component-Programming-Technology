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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Input1 = new Task4.Input();
            this.Output1 = new Task4.Output();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Input2 = new Task4.Input();
            this.Output2 = new Task4.Output();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TimeStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DateStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.InfoStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CalculateStripButton = new System.Windows.Forms.ToolStripButton();
            this.OpenStripButton = new System.Windows.Forms.ToolStripButton();
            this.SaveStripButton = new System.Windows.Forms.ToolStripButton();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MatricesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KeyboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 88);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(346, 277);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Input1);
            this.tabPage1.Controls.Add(this.Output1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(338, 251);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Subtask 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Input1
            // 
            this.Input1.Columns = 3;
            this.Input1.Location = new System.Drawing.Point(6, 6);
            this.Input1.Name = "Input1";
            this.Input1.Rows = 3;
            this.Input1.Size = new System.Drawing.Size(320, 237);
            this.Input1.TabIndex = 4;
            this.Input1.automaticButton_Click += new System.EventHandler(this.Input1_automaticButton_Click);
            this.Input1.manualButton_Click += new System.EventHandler(this.Input1_manualButton_Click);
            // 
            // Output1
            // 
            this.Output1.Data = null;
            this.Output1.DataColumns = 0;
            this.Output1.DataRows = 0;
            this.Output1.Location = new System.Drawing.Point(6, 6);
            this.Output1.Name = "Output1";
            this.Output1.outputText = "";
            this.Output1.Result = null;
            this.Output1.Size = new System.Drawing.Size(320, 237);
            this.Output1.TabIndex = 3;
            this.Output1.Visible = false;
            this.Output1.calculateButton_Click += new System.EventHandler(this.Output1_calculateButton_Click);
            this.Output1.clearButton_Click += new System.EventHandler(this.Output1_clearButton_Click);
            this.Output1.cancelButton_Click += new System.EventHandler(this.Output1_cancelButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Input2);
            this.tabPage2.Controls.Add(this.Output2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(338, 251);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Subtask 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Input2
            // 
            this.Input2.Columns = 3;
            this.Input2.Location = new System.Drawing.Point(6, 6);
            this.Input2.Name = "Input2";
            this.Input2.Rows = 3;
            this.Input2.Size = new System.Drawing.Size(320, 237);
            this.Input2.TabIndex = 0;
            this.Input2.automaticButton_Click += new System.EventHandler(this.Input2_automaticButton_Click);
            this.Input2.manualButton_Click += new System.EventHandler(this.Input2_manualButton_Click);
            // 
            // Output2
            // 
            this.Output2.Data = null;
            this.Output2.DataColumns = 0;
            this.Output2.DataRows = 0;
            this.Output2.Location = new System.Drawing.Point(6, 6);
            this.Output2.Name = "Output2";
            this.Output2.outputText = "";
            this.Output2.Result = null;
            this.Output2.Size = new System.Drawing.Size(320, 237);
            this.Output2.TabIndex = 1;
            this.Output2.Visible = false;
            this.Output2.calculateButton_Click += new System.EventHandler(this.Output2_calculateButton_Click);
            this.Output2.clearButton_Click += new System.EventHandler(this.Output2_clearButton_Click);
            this.Output2.cancelButton_Click += new System.EventHandler(this.Output2_cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(140, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arrays";
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TimeStatusLabel,
            this.DateStatusLabel,
            this.InfoStatusLabel});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 377);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(370, 22);
            this.StatusStrip1.TabIndex = 3;
            this.StatusStrip1.Text = "statusStrip1";
            // 
            // TimeStatusLabel
            // 
            this.TimeStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.TimeStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.TimeStatusLabel.Name = "TimeStatusLabel";
            this.TimeStatusLabel.Size = new System.Drawing.Size(38, 17);
            this.TimeStatusLabel.Text = "00:00";
            this.TimeStatusLabel.MouseEnter += new System.EventHandler(this.TimeStatusLabel_MouseEnter);
            // 
            // DateStatusLabel
            // 
            this.DateStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.DateStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.DateStatusLabel.Name = "DateStatusLabel";
            this.DateStatusLabel.Size = new System.Drawing.Size(53, 17);
            this.DateStatusLabel.Text = "1.1.1970";
            this.DateStatusLabel.MouseEnter += new System.EventHandler(this.DateStatusLabel_MouseEnter);
            // 
            // InfoStatusLabel
            // 
            this.InfoStatusLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.InfoStatusLabel.Name = "InfoStatusLabel";
            this.InfoStatusLabel.Size = new System.Drawing.Size(25, 17);
            this.InfoStatusLabel.Text = "Info";
            // 
            // SaveFileDialog1
            // 
            this.SaveFileDialog1.Filter = "MY Program|*.myp|All files|*.*";
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CalculateStripButton,
            this.OpenStripButton,
            this.SaveStripButton});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(370, 25);
            this.ToolStrip1.TabIndex = 4;
            this.ToolStrip1.Text = "toolStrip1";
            // 
            // CalculateStripButton
            // 
            this.CalculateStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CalculateStripButton.Image = ((System.Drawing.Image)(resources.GetObject("CalculateStripButton.Image")));
            this.CalculateStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CalculateStripButton.Name = "CalculateStripButton";
            this.CalculateStripButton.Size = new System.Drawing.Size(55, 22);
            this.CalculateStripButton.Text = "Calculate";
            this.CalculateStripButton.Click += new System.EventHandler(this.CalculateStripButton_Click);
            this.CalculateStripButton.MouseEnter += new System.EventHandler(this.CalculateStripButton_MouseEnter);
            // 
            // OpenStripButton
            // 
            this.OpenStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OpenStripButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenStripButton.Image")));
            this.OpenStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenStripButton.Name = "OpenStripButton";
            this.OpenStripButton.Size = new System.Drawing.Size(37, 22);
            this.OpenStripButton.Text = "Open";
            this.OpenStripButton.Click += new System.EventHandler(this.OpenStripButton_Click);
            this.OpenStripButton.MouseEnter += new System.EventHandler(this.OpenStripButton_MouseEnter);
            // 
            // SaveStripButton
            // 
            this.SaveStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SaveStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveStripButton.Image")));
            this.SaveStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveStripButton.Name = "SaveStripButton";
            this.SaveStripButton.Size = new System.Drawing.Size(36, 22);
            this.SaveStripButton.Text = "Save";
            this.SaveStripButton.Click += new System.EventHandler(this.SaveStripButton_Click);
            this.SaveStripButton.MouseEnter += new System.EventHandler(this.SaveStripButton_MouseEnter);
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(370, 24);
            this.MenuStrip1.TabIndex = 5;
            this.MenuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MatricesToolStripMenuItem,
            this.KeyboardToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // MatricesToolStripMenuItem
            // 
            this.MatricesToolStripMenuItem.Name = "MatricesToolStripMenuItem";
            this.MatricesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.MatricesToolStripMenuItem.Text = "Matrices";
            this.MatricesToolStripMenuItem.Click += new System.EventHandler(this.MatricesToolStripMenuItem_Click);
            // 
            // KeyboardToolStripMenuItem
            // 
            this.KeyboardToolStripMenuItem.Name = "KeyboardToolStripMenuItem";
            this.KeyboardToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.KeyboardToolStripMenuItem.Text = "Keyboard";
            this.KeyboardToolStripMenuItem.Click += new System.EventHandler(this.KeyboardToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.Filter = "MY Program|*.myp|All files|*.*";
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(370, 399);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.MenuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.MenuStrip1;
            this.Name = "Form1";
            this.Text = "Task 5";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Input Input2;
        private Output Output1;
        private Output Output2;
        private Input Input1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip StatusStrip1;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog1;
        private System.Windows.Forms.ToolStrip ToolStrip1;
        private System.Windows.Forms.ToolStripButton CalculateStripButton;
        private System.Windows.Forms.ToolStripButton OpenStripButton;
        private System.Windows.Forms.ToolStripButton SaveStripButton;
        private System.Windows.Forms.MenuStrip MenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MatricesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KeyboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        private System.Windows.Forms.ToolStripStatusLabel TimeStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel DateStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel InfoStatusLabel;
        private System.Windows.Forms.Timer Timer1;
    }
}

