using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tester_c_sharp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Retrieve ret1 = new Retrieve();
            ret1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search S1 = new Search();
            S1.Show();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ret1 = new Form1();
            ret1.Show();
        }
    }
}
