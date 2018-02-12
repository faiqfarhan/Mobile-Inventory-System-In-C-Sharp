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
    public partial class admin_update_manual : Form
    {
        //making variables of SqlDataAdapter,SqlCommandBuilder and DataTable
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public admin_update_manual()
        {
            InitializeComponent();
            //loads database on form load
            Connection con = new Connection();
            sda = new SqlDataAdapter(" SELECT id, category, model, quantity, price FROM Mobile", con.ActiveCon());
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void update_mobile_Load(object sender, EventArgs e)
        {

        }

        

       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        //updates textboxes value in database against their own specific id
        private void button5_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand(" UPDATE Mobile SET category = '" + textBox6.Text + "', model = '" + textBox1.Text + "', quantity = '" + textBox2.Text + "', price = '" + textBox3.Text + "' WHERE (id ='" + textBox7.Text + "' )", con.ActiveCon());
            cmd.ExecuteNonQuery();
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //refeshes the loaded database at runtime to see updated values
        private void button1_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            sda = new SqlDataAdapter(" SELECT id, category, model, quantity, price FROM Mobile", con.ActiveCon());
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        //logout button
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are Logged Out."); 
            this.Hide();
            admin_login al = new admin_login();
            al.Show();
        }
        //If click on specific Menu Strip item then show that clicked form and hide this one.
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_main al = new admin_main();
            al.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_add_mobile al = new admin_add_mobile();
            al.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_view_all al = new admin_view_all();
            al.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_view_manual al = new admin_view_manual();
            al.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_update_from_table al = new admin_update_from_table();
            al.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_update_manual al = new admin_update_manual();
            al.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_delete_mobile al = new admin_delete_mobile();
            al.Show();
        }
    }
}
