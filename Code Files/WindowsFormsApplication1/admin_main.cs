using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class admin_main : Form
    {
        public admin_main()
        {
            InitializeComponent();
        }

        private void admin_main_Load(object sender, EventArgs e)
        {

        }
        //If click on specific Menu Strip item then show that clicked form and hide this one.
        private void viewAllToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            admin_view_all dm = new admin_view_all();
            dm.Show();
        }

        private void viewManuallyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            admin_view_manual dm = new admin_view_manual();
            dm.Show();
        }

        private void addMobileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_add_mobile am = new admin_add_mobile();
            am.Show();
        }

        private void updateFromTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_update_from_table dm = new admin_update_from_table();
            dm.Show();
        }

        private void updateManuallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_update_manual dm = new admin_update_manual();
            dm.Show();
        }

        private void deleteMobileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_delete_mobile dm = new admin_delete_mobile();
            dm.Show();
        }

        //Logout Button
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are Logged Out."); 
            this.Hide();
            admin_login mn = new admin_login();
            mn.Show();
        }
    }
}
