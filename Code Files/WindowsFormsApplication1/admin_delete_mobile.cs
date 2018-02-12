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
    public partial class admin_delete_mobile : Form
    {
        //Makes a new connection
        Connection con = new Connection();

        public admin_delete_mobile()
        {
            InitializeComponent();
        }

        //Delete Button
        private void button5_Click(object sender, EventArgs e)
        {
            //if clicked then fetch all record against the given id and delete it.
            SqlCommand cmd = new SqlCommand(" DELETE From Mobile WHERE (id ='" + textBox7.Text + "' )", con.ActiveCon());

            cmd.ExecuteNonQuery();
            MessageBox.Show("Mobile with id: " + textBox7.Text + " is Deleted.");
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

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

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
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are Logged Out.");
            this.Hide();
            admin_login am = new admin_login();
            am.Show();
        }
    }
}
