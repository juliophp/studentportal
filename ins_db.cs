using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentPortal
{
    public partial class ins_db : Form
    {
        public ins_db(String Insname, String id)
        {
            InitializeComponent();
            msg.Text += " " + Insname;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=adeyemi;Initial Catalog=studentportal;Integrated Security=True";
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from instructors where id = @id";

            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.HasRows)
            {
                fname.Text = dr["first_name"].ToString();
                lname.Text = dr["last_name"].ToString();
                uname.Text = dr["username"].ToString();
                dname.Text = dr["department"].ToString();
                phone.Text = dr["phone_no"].ToString();
                office_no.Text = dr["office_no"].ToString();
            }
        }


        
    }
}
