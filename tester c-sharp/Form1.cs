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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADD_book add1 = new ADD_book();
            add1.Show();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 F2 = new Form2();
            F2.Show();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search S1 = new Search();
            S1.Show();
        }
    }
}
