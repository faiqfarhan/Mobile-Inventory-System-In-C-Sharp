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
    public partial class admin_view_manual : Form
    {
        public admin_view_manual()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        //show full record of entered category
        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda;
            DataTable dt;
            Connection con = new Connection();
            //searches in database for specific category and display full record
            sda = new SqlDataAdapter(" SELECT id, category, model, quantity, price FROM Mobile Where (category ='" + textBox1.Text + "' )", con.ActiveCon());
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

            //counts total mobiles in that specific category
            string query = " SELECT COUNT(model) FROM Mobile Where (category ='" + textBox1.Text + "' )";
            SqlDataAdapter sda1 = new SqlDataAdapter(query, con.ActiveCon());
            DataTable source = new DataTable();
            sda1.Fill(source);
            label4.Text = textBox1.Text + " phones are " + source.Rows[0][0].ToString();
            label3.Visible = true;
        }

        private void admin_view_manual_category_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_main am = new admin_main();
            am.Show();
        }
        //show full record of entered model
        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlDataAdapter sda;
            DataTable dt;
            Connection con = new Connection();
            //searches in database for specific model and display full record
            sda = new SqlDataAdapter(" SELECT id, category, model, quantity, price FROM Mobile Where (model ='" + textBox2.Text + "' )", con.ActiveCon());
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;

            using (SqlCommand cmd = new SqlCommand("select quantity from Mobile  WHERE (model = '" + textBox2.Text + "')", con.ActiveCon()))
            {
                //Execute the query and just get the first result.
                int value = (int)cmd.ExecuteScalar();
                label5.Text = textBox2.Text + " phones are " + value;
                label6.Visible = true;
            }
           
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }
        //If click on specific Menu Strip item then show that clicked form and hide this one.
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_add_mobile am = new admin_add_mobile();
            am.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_view_all dm = new admin_view_all();
            dm.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_view_manual dm = new admin_view_manual();
            dm.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_update_from_table dm = new admin_update_from_table();
            dm.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_update_manual dm = new admin_update_manual();
            dm.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_delete_mobile dm = new admin_delete_mobile();
            dm.Show();
        }
        //logout button
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are Logged Out."); 
            this.Hide();
            admin_login mn = new admin_login();
            mn.Show();
        }
    }
}
