using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace tester_c_sharp
{
    public partial class ADD_book : Form
    {
        public ADD_book()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            // Writing the data into the file
            string path = @"C:\Users\zaina\Documents\Visual Studio by IBEM\FOUR by FOUR\MINI PROJECT\TESTER\tester c-sharp\lib_dat.txt";
            //string title = "Book Title : ";
            //title += bookTitle.Text;
            //string author = "Author Name : ";
            //author += AuthorName.Text;
            //string iSBN = "ISBN : ";
            //iSBN += ISBN.Text;
            //string copy = "Number of copies : ";
            //copy += copies.Text += "\r\n";
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(bookTitle.Text);
                sw.WriteLine(AuthorName.Text);
                sw.WriteLine(ISBN.Text);
                sw.WriteLine(copies.Text);
            }
            MessageBox.Show("\tCONGRATS!\r\n\r\nBOOK ADDED SUCCESSFULLY!",
                    "ADDED",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            this.Hide();
            ADD_book ad1 = new ADD_book();
            ad1.Show();
        }
    }
}
