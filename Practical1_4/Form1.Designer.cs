namespace Practical1_4
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conversionToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feetToInchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inchesToFeetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poundToEuroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.euroToPoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.celsiusToFahrenheitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fahrenheitToCelsiusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.heading = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(291, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conversionToolToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // conversionToolToolStripMenuItem
            // 
            this.conversionToolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.feetToInchesToolStripMenuItem,
            this.inchesToFeetToolStripMenuItem,
            this.poundToEuroToolStripMenuItem,
            this.euroToPoundToolStripMenuItem,
            this.celsiusToFahrenheitToolStripMenuItem,
            this.fahrenheitToCelsiusToolStripMenuItem});
            this.conversionToolToolStripMenuItem.Name = "conversionToolToolStripMenuItem";
            this.conversionToolToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.conversionToolToolStripMenuItem.Text = "Conversion Tool";
            // 
            // feetToInchesToolStripMenuItem
            // 
            this.feetToInchesToolStripMenuItem.Name = "feetToInchesToolStripMenuItem";
            this.feetToInchesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.feetToInchesToolStripMenuItem.Text = "Feet to Inches";
            this.feetToInchesToolStripMenuItem.Click += new System.EventHandler(this.feetToInchesToolStripMenuItem_Click);
            // 
            // inchesToFeetToolStripMenuItem
            // 
            this.inchesToFeetToolStripMenuItem.Name = "inchesToFeetToolStripMenuItem";
            this.inchesToFeetToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.inchesToFeetToolStripMenuItem.Text = "Inches to Feet";
            this.inchesToFeetToolStripMenuItem.Click += new System.EventHandler(this.inchesToFeetToolStripMenuItem_Click);
            // 
            // poundToEuroToolStripMenuItem
            // 
            this.poundToEuroToolStripMenuItem.Name = "poundToEuroToolStripMenuItem";
            this.poundToEuroToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.poundToEuroToolStripMenuItem.Text = "Pound to Euro";
            this.poundToEuroToolStripMenuItem.Click += new System.EventHandler(this.poundToEuroToolStripMenuItem_Click);
            // 
            // euroToPoundToolStripMenuItem
            // 
            this.euroToPoundToolStripMenuItem.Name = "euroToPoundToolStripMenuItem";
            this.euroToPoundToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.euroToPoundToolStripMenuItem.Text = "Euro to Pound";
            this.euroToPoundToolStripMenuItem.Click += new System.EventHandler(this.euroToPoundToolStripMenuItem_Click);
            // 
            // celsiusToFahrenheitToolStripMenuItem
            // 
            this.celsiusToFahrenheitToolStripMenuItem.Name = "celsiusToFahrenheitToolStripMenuItem";
            this.celsiusToFahrenheitToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.celsiusToFahrenheitToolStripMenuItem.Text = "Celsius to Fahrenheit";
            this.celsiusToFahrenheitToolStripMenuItem.Click += new System.EventHandler(this.celsiusToFahrenheitToolStripMenuItem_Click);
            // 
            // fahrenheitToCelsiusToolStripMenuItem
            // 
            this.fahrenheitToCelsiusToolStripMenuItem.Name = "fahrenheitToCelsiusToolStripMenuItem";
            this.fahrenheitToCelsiusToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.fahrenheitToCelsiusToolStripMenuItem.Text = "Fahrenheit to Celsius";
            this.fahrenheitToCelsiusToolStripMenuItem.Click += new System.EventHandler(this.fahrenheitToCelsiusToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(104, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.heading);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 170);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Location = new System.Drawing.Point(101, 9);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(75, 13);
            this.heading.TabIndex = 5;
            this.heading.Text = "Feet to Inches";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(41, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(43, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Feet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 219);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conversionToolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feetToInchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inchesToFeetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poundToEuroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem euroToPoundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem celsiusToFahrenheitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fahrenheitToCelsiusToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

