using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentPortal
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();

            lst.Items.Add("Student");
            lst.Items.Add("Instructor");
        }

        

        private void login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=adeyemi;Initial Catalog=studentportal;Integrated Security=True";
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            if(lst.SelectedItem.ToString() == "Student")
            {
                cmd.CommandText = "Select * from students where username = @id and password = @pwd";

                cmd.Parameters.AddWithValue("@id", username.Text);
                cmd.Parameters.AddWithValue("@pwd", password.Text);


                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows && dr["username"].ToString() == username.Text)
                {
                    String stdname = dr["username"].ToString();
                    this.Hide();
                    frm_db db = new frm_db(stdname, dr["id"].ToString());
                    db.Show();
                }
                else
                {
                    msg.Text = "The username and password is not correct";
                }
            }
            else if (lst.SelectedItem.ToString() == "Instructor")
            {
                cmd.CommandText = "Select * from instructors where username = @id and password = @pwd";

                cmd.Parameters.AddWithValue("@id", username.Text);
                cmd.Parameters.AddWithValue("@pwd", password.Text);


                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();


                if (dr.HasRows && dr["username"].ToString() == username.Text)
                {
                    String insname = dr["username"].ToString();
                    this.Hide();
                    ins_db db = new ins_db(insname, dr["id"].ToString());
                    db.Show();
                }
                else
                {
                    msg.Text = "The username and password is not correct";
                }
            }
           


        }

        private void register_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register rg = new Register();
            rg.Show();
        }
    }
}
