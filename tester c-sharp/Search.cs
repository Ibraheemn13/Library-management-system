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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\zaina\Documents\Visual Studio by IBEM\FOUR by FOUR\MINI PROJECT\TESTER\tester c-sharp\lib_dat.txt";
            string str = textBox1.Text;
            StreamReader reader = new StreamReader(path);
            string line = "";
            while((line=reader.ReadLine())!=null)
            {
                if(str==line)
                {

                    textBox2.Text = line;
                    line = reader.ReadLine();
                    textBox3.Text = line;
                    line = reader.ReadLine();
                    textBox4.Text = line;
                    line = reader.ReadLine();
                    textBox5.Text = line;
                    break;
                }
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
