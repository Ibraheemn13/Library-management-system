
namespace tester_c_sharp
{
    partial class Retrieve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Retrieve));
            this.Back_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.bg_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Back_button
            // 
            this.Back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_button.Location = new System.Drawing.Point(206, 380);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(73, 23);
            this.Back_button.TabIndex = 21;
            this.Back_button.Text = "BACK";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button.Location = new System.Drawing.Point(549, 380);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(73, 23);
            this.exit_button.TabIndex = 20;
            this.exit_button.Text = "EXIT";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // bg_label
            // 
            this.bg_label.BackColor = System.Drawing.Color.Gainsboro;
            this.bg_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bg_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.bg_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bg_label.Location = new System.Drawing.Point(179, 32);
            this.bg_label.Name = "bg_label";
            this.bg_label.Size = new System.Drawing.Size(467, 397);
            this.bg_label.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(206, 95);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(416, 264);
            this.textBox1.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(339, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 22);
            this.label5.TabIndex = 34;
            this.label5.Text = "BOOKS RECORD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Bisque;
            this.label7.Font = new System.Drawing.Font("Baron Neue Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(636, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 30);
            this.label7.TabIndex = 35;
            this.label7.Text = "M. Ibraheem Noor\r\n21F-9068";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Retrieve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.bg_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Retrieve";
            this.Text = "Library Managment System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label bg_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}