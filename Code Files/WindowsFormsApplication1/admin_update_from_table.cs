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
    public partial class admin_update_from_table : Form
    {
        //making variables of dataadapter, sqlcommandbuilder and datatable
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;

        public admin_update_from_table()
        {
            InitializeComponent();
            //makes a new connection
            Connection con = new Connection();
            //fills whole database in datagridview on load 
            sda = new SqlDataAdapter(" SELECT id, category, model, quantity, price FROM Mobile", con.ActiveCon());
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void admin_update_from_table_Load(object sender, EventArgs e)
        {

        }
        //updates database
        private void button6_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
        }
        //If click on specific Menu Strip item then show that clicked form and hide this one.
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_main um = new admin_main();
            um.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_add_mobile um = new admin_add_mobile();
            um.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_view_all um = new admin_view_all();
            um.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_view_manual um = new admin_view_manual();
            um.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_update_from_table um = new admin_update_from_table();
            um.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_update_manual um = new admin_update_manual();
            um.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_delete_mobile um = new admin_delete_mobile();
            um.Show();
        }
        //logout button
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are Logged Out."); 
            this.Hide();
            admin_login um = new admin_login();
            um.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
