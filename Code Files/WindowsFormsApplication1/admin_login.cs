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
    public partial class admin_login : Form
    {
        public admin_login()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //Admin Login authenticator
        private void button2_Click(object sender, EventArgs e)
        {   
            //if username and password is "admin", then it logins as admin 
            if (textBox3.Text == "admin" && textBox4.Text == "admin"){
                MessageBox.Show("Login Successful.");
                this.Hide();
                admin_main mn = new admin_main();
                mn.Show();
            }
            else{
                MessageBox.Show("Error! Please Check your Username or Password.");
            }
        }

        //Exits all forms
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void admin_login_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        //Sign in as user Button
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            user_login ul = new user_login();
            ul.Show();
        }
    }

}
