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
    public partial class admin_view_all : Form
    {
        SqlDataAdapter sda;
        //SqlCommandBuilder scb;
        DataTable dt;

        public admin_view_all()
        {
            InitializeComponent();
            //loads database into datagridview at runtime
            Connection con = new Connection();
            sda = new SqlDataAdapter(" SELECT id, category, model, quantity, price FROM Mobile", con.ActiveCon());
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void admin_view_all_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }
        //If click on specific Menu Strip item then show that clicked form and hide this one.
        private void toolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            admin_view_all am = new admin_view_all();
            am.Show();
        }

        private void toolStripMenuItem5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            admin_view_manual am = new admin_view_manual();
            am.Show();
        }

        private void toolStripMenuItem7_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            admin_update_from_table am = new admin_update_from_table();
            am.Show();
        }

        private void toolStripMenuItem8_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            admin_update_manual am = new admin_update_manual();
            am.Show();
        }

        private void toolStripMenuItem9_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            admin_delete_mobile am = new admin_delete_mobile();
            am.Show();
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            admin_main am = new admin_main();
            am.Show();
        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            admin_add_mobile am = new admin_add_mobile();
            am.Show();
        }

        //logout button
        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("You are Logged Out."); 
            this.Hide();
            admin_login mn = new admin_login();
            mn.Show();
        }
    }
}
