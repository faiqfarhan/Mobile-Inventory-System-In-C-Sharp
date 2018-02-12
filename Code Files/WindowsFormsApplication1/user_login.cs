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
using System.Net.Mail;

namespace WindowsFormsApplication1
{
    public partial class user_login : Form
    {
        //making variables of connection and adapters and datatables
        Connection con = new Connection();
        SqlDataAdapter sda = new SqlDataAdapter();
        SqlDataAdapter sda1 = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();

        public user_login()
        {
            InitializeComponent();
        }

        //login button
        private void button2_Click(object sender, EventArgs e)
        {
            //checks if user is already present in database or not
            sda = new SqlDataAdapter("Select Count(*) from Login where Username = '" + textBox1.Text +"' and Password = '" + textBox2.Text +"'", con.ActiveCon());
            sda.Fill(dt);
            //if yes then login successful
            if (dt.Rows[0][0].ToString() == "1"){
                MessageBox.Show("Login Successful.");
                this.Hide();
                //to show user's First name and Last Name in next all forms, passing name as value to user_main form call
                sda1 = new SqlDataAdapter("Select First_Name, Last_Name from Login where Username = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'", con.ActiveCon());
                sda1.Fill(dt1);
                user_main mn = new user_main((dt1.Rows[0][0].ToString() + dt1.Rows[0][1].ToString()).ToString());
                
                mn.Show();
            }
            //if not then login error
            else
            {
                MessageBox.Show("Error! Please Check your Username or Password.");
            }
        }

        private void user_login_Load(object sender, EventArgs e)
        {

        }
        //SignUp Button
        private void button5_Click(object sender, EventArgs e)
        {
            //datetime conversion
            string dateString = this.dateTimePicker1.Text;
            DateTime Date = Convert.ToDateTime(dateString.ToString());
            
            SqlCommand cmd = new SqlCommand("",con.ActiveCon());
            //add a new user and inserts its values in database and then login
            cmd.CommandText = "INSERT INTO Login (Username,Password,First_Name, Last_Name,Email, Birthday, Gender) VALUES (@username,@password,@frst_name, @lst_name, @email, @birthday,@gender)";
            cmd.Parameters.AddWithValue("@username", textBox3.Text);
            cmd.Parameters.AddWithValue("@password", textBox4.Text);
            cmd.Parameters.AddWithValue("@frst_name", textBox5.Text);
            cmd.Parameters.AddWithValue("@lst_name", textBox6.Text);
            cmd.Parameters.AddWithValue("@email", textBox7.Text);
            cmd.Parameters.AddWithValue("@birthday", Date.ToShortDateString());
            //radio buttons
            if (radioButton1.Checked)
                cmd.Parameters.AddWithValue("@gender", "Male");
            else
                cmd.Parameters.AddWithValue("@gender", "Female");
            cmd.ExecuteNonQuery();

            //handling exception when mail is send
            try
            {
                //makes a mail message
                MailMessage mail = new MailMessage();
                //makes a new smtp server
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                //admins email id
                mail.From = new MailAddress("faiqtestemail@gmail.com");
                //users email id
                mail.To.Add(textBox7.Text);
                //subject of mail
                mail.Subject = "Mobile Inventory System - Sign Up Successful";
                //body of mail
                mail.Body = "Welcome " +textBox5.Text +". You have been successfully signed up in Mobile Inventory System.\n\nYour username is: " + textBox3.Text + " and Password is: " + textBox4.Text;
                //port =25
                SmtpServer.Port = 25;
                //username and password of admin 
                SmtpServer.Credentials = new System.Net.NetworkCredential("faiqtestemail", "seecs@123");
                SmtpServer.EnableSsl = true;
                //mail send
                SmtpServer.Send(mail);
                //success
                MessageBox.Show("Sign Up Successfull.\nA welcome mail is send to your email address also.");
                //redirects to main form
                this.Hide();
                sda1 = new SqlDataAdapter("Select First_Name, Last_Name from Login where Username = '" + textBox3.Text + "' and Password = '" + textBox4.Text + "'", con.ActiveCon());
                sda1.Fill(dt1);
                user_main mn = new user_main((dt1.Rows[0][0].ToString()+ dt1.Rows[0][1].ToString()).ToString());
                mn.Show();

            }
                //exception occurs
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            
        }
        
        //Exits Windows Form Application
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
