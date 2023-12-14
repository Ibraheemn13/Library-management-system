
namespace tester_c_sharp
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.exit_button = new System.Windows.Forms.Button();
            this.bg_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Back_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exit_button
            // 
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button.Location = new System.Drawing.Point(429, 367);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(73, 23);
            this.exit_button.TabIndex = 8;
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
            this.bg_label.Location = new System.Drawing.Point(256, 34);
            this.bg_label.Name = "bg_label";
            this.bg_label.Size = new System.Drawing.Size(288, 383);
            this.bg_label.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(295, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 80);
            this.button1.TabIndex = 9;
            this.button1.Text = "GET ALL DATA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(416, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 80);
            this.button2.TabIndex = 10;
            this.button2.Text = "SEARCH SPECIFIC DATA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(320, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "RETRIEVE BOOK";
            // 
            // Back_button
            // 
            this.Back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_button.Location = new System.Drawing.Point(295, 367);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(73, 23);
            this.Back_button.TabIndex = 20;
            this.Back_button.Text = "BACK";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Bisque;
            this.label7.Font = new System.Drawing.Font("Baron Neue Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(563, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 30);
            this.label7.TabIndex = 21;
            this.label7.Text = "Muhammad Ibraheem Noor\r\n21F-9068";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.bg_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Library Managment System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label bg_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Label label7;
    }
}