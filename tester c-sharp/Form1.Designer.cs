
namespace tester_c_sharp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bg_label = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bg_label
            // 
            this.bg_label.BackColor = System.Drawing.Color.Gainsboro;
            this.bg_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bg_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.bg_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bg_label.Location = new System.Drawing.Point(272, 45);
            this.bg_label.Name = "bg_label";
            this.bg_label.Size = new System.Drawing.Size(288, 383);
            this.bg_label.TabIndex = 0;
            // 
            // add_button
            // 
            this.add_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_button.BackgroundImage")));
            this.add_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_button.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add_button.Location = new System.Drawing.Point(318, 167);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(78, 77);
            this.add_button.TabIndex = 2;
            this.add_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // update_button
            // 
            this.update_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("update_button.BackgroundImage")));
            this.update_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.update_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_button.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.update_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.update_button.Location = new System.Drawing.Point(426, 167);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(78, 77);
            this.update_button.TabIndex = 3;
            this.update_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete_button.BackgroundImage")));
            this.delete_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_button.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delete_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.delete_button.Location = new System.Drawing.Point(426, 257);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(78, 77);
            this.delete_button.TabIndex = 4;
            this.delete_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.delete_button.UseVisualStyleBackColor = true;
            // 
            // search_button
            // 
            this.search_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_button.BackgroundImage")));
            this.search_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_button.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.search_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.search_button.Location = new System.Drawing.Point(318, 257);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(78, 77);
            this.search_button.TabIndex = 5;
            this.search_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button.Location = new System.Drawing.Point(376, 378);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(73, 23);
            this.exit_button.TabIndex = 6;
            this.exit_button.Text = "EXIT";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(313, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 66);
            this.label5.TabIndex = 35;
            this.label5.Text = "WELCOME TO\r\nLIBRARY\r\nMANAGMENT SYSTEM";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Bisque;
            this.label7.Font = new System.Drawing.Font("Baron Neue Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(566, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 30);
            this.label7.TabIndex = 36;
            this.label7.Text = "Muhammad Ibraheem Noor\r\n21F-9068";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.bg_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Library Managment System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bg_label;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}

