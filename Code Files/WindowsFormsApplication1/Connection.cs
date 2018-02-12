using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication1
{
    class Connection
    {
        //i couldnt give it a relative path so you had to do this

        //Making a Universal Connection because i had to copy this below string in every connection call
        //Just Right click on the "Data.mdf" in "Database explorer toolbar" under the Data Connection and select properties 
        //then copy Connection String given in the properties to following brackets after @ and in inverted commas
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Faiq\Documents\Visual Studio 2012\Projects\WindowsFormsApplication1\Data.mdf;Integrated Security=True;Connect Timeout=30");
        
        public SqlConnection ActiveCon() {
            //checks if Connection is closed then open it
            if (con.State == ConnectionState.Closed)
            {
                con.Open();            
            }
            return con;
        }
    }
}
