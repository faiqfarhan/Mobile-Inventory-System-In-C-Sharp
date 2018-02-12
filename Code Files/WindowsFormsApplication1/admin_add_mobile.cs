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
    public partial class admin_add_mobile : Form
    {
        //Making a new connection
        Connection con = new Connection();

        public admin_add_mobile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_mobile_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            //Makes a new data adapter to check if input mobile exists in database or not. 
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from Mobile where category = '" + textBox2.Text + "' and model = '" + textBox3.Text + "'", con.ActiveCon());
            DataTable dt = new DataTable();
            //fills datatable 
            sda.Fill(dt);
            
            if (dt.Rows[0][0].ToString() == "1")
            {
                //if exists then add 1 in the quantity of that mobile
                SqlCommand cmd = new SqlCommand("UPDATE Mobile SET quantity = quantity + 1 WHERE (category = '" + textBox2.Text + "' and model = '" + textBox3.Text + "')", con.ActiveCon());

                cmd.ExecuteNonQuery();
               
                MessageBox.Show("Mobile is Already Present, so quantity of " + textBox2.Text + " " +textBox3.Text +  " is increased");
            }
            else
            {
                //if not exist then add a new row in the table
                SqlCommand cmd = new SqlCommand(" INSERT INTO Mobile(category, model, price) VALUES('" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox6.Text + "')", con.ActiveCon());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Mobile Successfully Added.");
            }

            
        }
        //If click on specific Menu Strip item then show that clicked form and hide this one.
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_main am = new admin_main();
            am.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_add_mobile am = new admin_add_mobile();
            am.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_view_all am = new admin_view_all();
            am.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_view_manual am = new admin_view_manual();
            am.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_update_from_table am = new admin_update_from_table();
            am.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_update_manual am = new admin_update_manual();
            am.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_delete_mobile am = new admin_delete_mobile();
            am.Show();
        }

        //Logout Button
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are Logged Out.");
            this.Hide();
            admin_login am = new admin_login();
            am.Show();
        }
    }
}
