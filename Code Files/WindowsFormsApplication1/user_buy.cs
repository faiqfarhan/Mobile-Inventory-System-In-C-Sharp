using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using System.IO;
//libraries include for pdf conversion
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data.SqlClient;
using System.Collections;
namespace WindowsFormsApplication1
{
    public partial class user_buy : Form
    {
        int id;
        Connection con = new Connection();
        public user_buy(string str)
        {
            InitializeComponent();
            //loads database in datagridview on form load
            SqlDataAdapter sda;
            DataTable dt;
            sda = new SqlDataAdapter(" SELECT id, category, model, quantity, price FROM Mobile", con.ActiveCon());
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            label1.Text = str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //makes a new pdf document
            Document document = new Document(PageSize.A4, 25, 25, 30, 30);
            //name of document and type
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream("Order.pdf", FileMode.Create));
            document.Open();
            int num = -1;
            //adds first paragraph
            Paragraph p0 = new Paragraph("                         Your Order:\n\nQuantity            Model                  Price\n\n");
            document.Add(p0);

            //Adds full data of shopping cart to the paragraph in pdf, quantity, model and price of every mobile
            foreach (DataGridViewRow item in dataGridView2.Rows)
            {
                num = item.Index;
                
                Paragraph p1 = new Paragraph(dataGridView2.Rows[num].Cells[2].Value.ToString() + "                       " + dataGridView2.Rows[num].Cells[1].Value.ToString() + "                      " + dataGridView2.Rows[num].Cells[3].Value.ToString());
            document.Add(p1);
            }
            //decrements quantity of every mobile which are checked out
            int count = -1;
            foreach (DataGridViewRow qntity in dataGridView2.Rows)
            {
                count = qntity.Index;
                Connection con = new Connection();
                SqlCommand cmd = new SqlCommand("UPDATE Mobile SET quantity = quantity - '" + dataGridView2.Rows[count].Cells[2].Value.ToString() + "' WHERE (model = '" + dataGridView2.Rows[count].Cells[1].Value.ToString() + "')", con.ActiveCon());
                cmd.ExecuteNonQuery();
            }
            int error_count = -1;

            //checks if quantity of a mobile which is decremented becomes less than 0 than, then gives stock error and order is cancelled
            foreach (DataGridViewRow qntity in dataGridView2.Rows)
            {
                error_count = qntity.Index;
                using (SqlCommand cmd = new SqlCommand("select quantity from Mobile  WHERE (model = '" + dataGridView2.Rows[error_count].Cells[1].Value.ToString() + "')", con.ActiveCon()))
                {
                    //Execute the query and just get the first result.
                    int value = (int)cmd.ExecuteScalar();
                    if (value < 0)
                    {
                        //if quantity < 0, then error
                        MessageBox.Show("Error!!! Out of Stock.");
                        Connection conn = new Connection();
                        SqlCommand cmd1 = new SqlCommand("UPDATE Mobile SET quantity = quantity + '" + dataGridView2.Rows[error_count].Cells[2].Value.ToString() + "' WHERE (model = '" + dataGridView2.Rows[error_count].Cells[1].Value.ToString() + "')", conn.ActiveCon());
                        cmd1.ExecuteNonQuery();
                        Application.Exit();
                    }
                    else {
                        //if quantity is ok, then adds total price to the pdf
                        Paragraph p2 = new Paragraph("\n               Total Price: Rs. " + label13.Text);
                        document.Add(p2);
                        document.Close();
                        writer.Close();

                        //Opens the pdf file
                        //You have to set its path locally
                        //As @"Drive\..\Visual Studio\Projects\App1\bin\Debug\Order.pdf"
                        //i just gave a rough sample
                        System.Diagnostics.Process.Start(@"C:\Users\Faiq\Documents\Visual Studio 2012\Projects\WindowsFormsApplication1\WindowsFormsApplication1\bin\Debug\Order.pdf");
       
                    }
                }
            }

          }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            //textBox2.Text = "";
        }
        //displays data of selected row in datagridview to labels in order pending dynamically
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Visible = true;
            label5.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            //checks which row is selected and stores it in id
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
            SqlCommand cmd = con.ActiveCon().CreateCommand();
            cmd.CommandType = CommandType.Text;
            
            cmd.CommandText = " SELECT id, category, model, quantity, price FROM Mobile where id = " + id + "";
            cmd.ExecuteNonQuery();
            DataTable dt =new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            //shows id, model and price in labels of selected row
            foreach (DataRow dr in dt.Rows) {
                label5.Text = dr["id"].ToString();
                label10.Text = dr["model"].ToString();
                label11.Text = dr["price"].ToString();
            }
        }
        //add to cart button
        private void button3_Click_1(object sender, EventArgs e)
        {
            //adds a new row in shopping cart based on selected data
            int n = dataGridView2.Rows.Add();
            ArrayList row = new ArrayList();
            //adding data of labels and textbox in table for a single row
            dataGridView2.Rows[n].Cells[0].Value = label5.Text;
            dataGridView2.Rows[n].Cells[1].Value = label10.Text;
            dataGridView2.Rows[n].Cells[2].Value = textBox1.Text;
            dataGridView2.Rows[n].Cells[3].Value = Double.Parse(label11.Text.ToString()) * Double.Parse(textBox1.Text.ToString());
            
            //sum of all prices, result in total order price
            label13.Text = "0";
            int num = -1;
            foreach (DataGridViewRow item in dataGridView2.Rows)
            {
                num = item.Index;
                label13.Text = (Double.Parse(label13.Text.ToString()) + Double.Parse(dataGridView2.Rows[num].Cells[3].Value.ToString())).ToString();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        //clears shopping cart and order pending
        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            label5.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label13.Text = "0";

            this.dataGridView2.DataSource = null;
            this.dataGridView2.Rows.Clear();
            //this.dataGridView2.DataSource = this.GetNewValues();


        }
        //logout button
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are Logged Out."); 
            this.Hide();
            admin_login al = new admin_login();
            al.Show();
        }

        //If click on specific Menu Strip item then show that clicked form and hide this one.
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            user_main ub = new user_main(label1.Text);
            ub.Show();
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            user_search ub = new user_search(label1.Text);
            ub.Show();
        }

        private void buyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            user_buy ub = new user_buy(label1.Text);
            ub.Show();
        }

        
    }
}
