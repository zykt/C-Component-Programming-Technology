namespace Task8Remake
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
            this.PlotterButton = new System.Windows.Forms.Button();
            this.TrianglesButton = new System.Windows.Forms.Button();
            this.ShapesButton = new System.Windows.Forms.Button();
            this.BezierButton = new System.Windows.Forms.Button();
            this.display1 = new Task8Remake.Display();
            this.SuspendLayout();
            // 
            // PlotterButton
            // 
            this.PlotterButton.Location = new System.Drawing.Point(-1, 606);
            this.PlotterButton.Name = "PlotterButton";
            this.PlotterButton.Size = new System.Drawing.Size(75, 23);
            this.PlotterButton.TabIndex = 2;
            this.PlotterButton.Text = "Plotter";
            this.PlotterButton.UseVisualStyleBackColor = true;
            this.PlotterButton.Click += new System.EventHandler(this.PlotterButton_Click);
            // 
            // TrianglesButton
            // 
            this.TrianglesButton.Location = new System.Drawing.Point(73, 606);
            this.TrianglesButton.Name = "TrianglesButton";
            this.TrianglesButton.Size = new System.Drawing.Size(75, 23);
            this.TrianglesButton.TabIndex = 3;
            this.TrianglesButton.Text = "Triangles";
            this.TrianglesButton.UseVisualStyleBackColor = true;
            this.TrianglesButton.Click += new System.EventHandler(this.TrianglesButton_Click);
            // 
            // ShapesButton
            // 
            this.ShapesButton.Location = new System.Drawing.Point(224, 606);
            this.ShapesButton.Name = "ShapesButton";
            this.ShapesButton.Size = new System.Drawing.Size(75, 23);
            this.ShapesButton.TabIndex = 4;
            this.ShapesButton.Text = "Shapes";
            this.ShapesButton.UseVisualStyleBackColor = true;
            this.ShapesButton.Click += new System.EventHandler(this.ShapesButton_Click);
            // 
            // BezierButton
            // 
            this.BezierButton.Location = new System.Drawing.Point(150, 606);
            this.BezierButton.Name = "BezierButton";
            this.BezierButton.Size = new System.Drawing.Size(75, 23);
            this.BezierButton.TabIndex = 5;
            this.BezierButton.Text = "Bezier";
            this.BezierButton.UseVisualStyleBackColor = true;
            this.BezierButton.Click += new System.EventHandler(this.BezierButton_Click);
            // 
            // display1
            // 
            this.display1.BackColor = System.Drawing.Color.White;
            this.display1.Location = new System.Drawing.Point(0, 0);
            this.display1.Mode = Task8Remake.Display.DisplayMode.Plotter;
            this.display1.Name = "display1";
            this.display1.Size = new System.Drawing.Size(600, 600);
            this.display1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 628);
            this.Controls.Add(this.BezierButton);
            this.Controls.Add(this.ShapesButton);
            this.Controls.Add(this.TrianglesButton);
            this.Controls.Add(this.PlotterButton);
            this.Controls.Add(this.display1);
            this.Name = "Form1";
            this.Text = "Graphic";
            this.ResumeLayout(false);

        }

        #endregion

        private Display display1;
        private System.Windows.Forms.Button PlotterButton;
        private System.Windows.Forms.Button TrianglesButton;
        private System.Windows.Forms.Button ShapesButton;
        private System.Windows.Forms.Button BezierButton;
    }
}

