
namespace tester_c_sharp
{
    partial class ADD_book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADD_book));
            this.bg_label = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.bookTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AuthorName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ISBN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.copies = new System.Windows.Forms.TextBox();
            this.submit_button = new System.Windows.Forms.Button();
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
            this.bg_label.Location = new System.Drawing.Point(271, 45);
            this.bg_label.Name = "bg_label";
            this.bg_label.Size = new System.Drawing.Size(288, 383);
            this.bg_label.TabIndex = 1;
            // 
            // exit_button
            // 
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button.Location = new System.Drawing.Point(441, 379);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(73, 23);
            this.exit_button.TabIndex = 7;
            this.exit_button.Text = "EXIT";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_button.Location = new System.Drawing.Point(316, 379);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(73, 23);
            this.Back_button.TabIndex = 8;
            this.Back_button.Text = "BACK";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // bookTitle
            // 
            this.bookTitle.Location = new System.Drawing.Point(391, 142);
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.Size = new System.Drawing.Size(151, 23);
            this.bookTitle.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(286, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Book Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(286, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Author Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // AuthorName
            // 
            this.AuthorName.Location = new System.Drawing.Point(391, 190);
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(151, 23);
            this.AuthorName.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(286, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "ISBN";
            // 
            // ISBN
            // 
            this.ISBN.Location = new System.Drawing.Point(391, 239);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(151, 23);
            this.ISBN.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(286, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "No. of Copies";
            // 
            // copies
            // 
            this.copies.Location = new System.Drawing.Point(391, 284);
            this.copies.Name = "copies";
            this.copies.Size = new System.Drawing.Size(151, 23);
            this.copies.TabIndex = 15;
            // 
            // submit_button
            // 
            this.submit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submit_button.Location = new System.Drawing.Point(365, 338);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(99, 28);
            this.submit_button.TabIndex = 17;
            this.submit_button.Text = "SUBMIT";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(339, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "ADD NEW BOOK";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Bisque;
            this.label7.Font = new System.Drawing.Font("Baron Neue Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(565, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 30);
            this.label7.TabIndex = 20;
            this.label7.Text = "Muhammad Ibraheem Noor\r\n21F-9068";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ADD_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.copies);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AuthorName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookTitle);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.bg_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ADD_book";
            this.Text = "Library Managment System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bg_label;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.TextBox bookTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AuthorName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ISBN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox copies;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}