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
    public partial class Retrieve : Form
    {
        public Retrieve()
        {
            InitializeComponent();
            //string path = @"C:\Users\zaina\Documents\Visual Studio by IBEM\FOUR by FOUR\MINI PROJECT\TESTER\tester c-sharp\lib_dat.txt";
            //var str = File.ReadAllText(path);
            //textBox1.Text = str;
            string path = @"C:\Users\zaina\Documents\Visual Studio by IBEM\FOUR by FOUR\MINI PROJECT\TESTER\tester c-sharp\lib_dat.txt";
            StreamReader reader = new StreamReader(path);
            string line = "";
            while ((line = reader.ReadLine()) != null)
            {
                
                //line = "Book name : ";
                textBox1.Text += "Book name : ";
                //line += reader.ReadLine();
                textBox1.Text += line;
                textBox1.Text += "\r\n";

                line = "Author name : ";
                line += reader.ReadLine();
                textBox1.Text += line;
                textBox1.Text += "\r\n";

                line = "ISBN : ";
                line += reader.ReadLine();
                textBox1.Text += line;
                textBox1.Text += "\r\n";

                line = "Number of copies : ";
                line += reader.ReadLine();
                textBox1.Text += line;
                textBox1.Text += "\r\n----------------------------------\r\n";
            }
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

    }
}
