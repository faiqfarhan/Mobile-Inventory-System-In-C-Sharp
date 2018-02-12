using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class user_main : Form
    {
        public user_main(string name)
        {
            InitializeComponent();
            //sets user's first and last name in the label
            label1.Text = name;
        }

        private void user_main_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        //If click on specific Menu Strip item then show that clicked form and hide this one.
        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            user_search us = new user_search(label1.Text);
            us.Show();

        }
        private void buyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            user_buy ub = new user_buy(label1.Text);
            ub.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            user_main ub = new user_main(label1.Text);
            ub.Show();
        }
        //logout button
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            admin_login ub = new admin_login();
            ub.Show();
        }
    }
}
