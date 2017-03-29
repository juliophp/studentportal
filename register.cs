using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentPortal
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            NatBox.Items.Add("Nigerian");
            NatBox.Items.Add("American");
            NatBox.Items.Add("Turkish");
            NatBox.Items.Add("Cypriot");

            lst.Items.Add("Student");
            lst.Items.Add("Instructor");
        }

        private void reg_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=adeyemi;Initial Catalog=studentportal;Integrated Security=True";
            con.Open();
            if (lst.SelectedItem.ToString() == "Student")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into students(first_name, last_name, username, password, date_of_birth, nationality) values(@fname, @lname, @uname, @pwd, @dob, @nat)";

                cmd.Parameters.AddWithValue("@fname", fname.Text);
                cmd.Parameters.AddWithValue("@lname", lname.Text);
                cmd.Parameters.AddWithValue("@uname", uname.Text);
                cmd.Parameters.AddWithValue("@dob", dob.Text);
                cmd.Parameters.AddWithValue("@pwd", pwd.Text);
                cmd.Parameters.AddWithValue("@nat", NatBox.SelectedItem.ToString());

                int r = cmd.ExecuteNonQuery();

                if (r > 0)
                {
                    Result.Text = " Record Inserted";
                    this.Hide();
                    frm_login ln = new frm_login();
                    ln.Show();
                }
            }
            else if (lst.SelectedItem.ToString() == "Instructor")
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "insert into instructors(first_name, last_name, username, password) values(@fname, @lname, @uname, @pwd)";

                    cmd.Parameters.AddWithValue("@fname", fname.Text);
                    cmd.Parameters.AddWithValue("@lname", lname.Text);
                    cmd.Parameters.AddWithValue("@uname", uname.Text);
                    cmd.Parameters.AddWithValue("@pwd", pwd.Text);
                   

                    int r = cmd.ExecuteNonQuery();
                    if (r > 0)
                    {
                        Result.Text = " Record Inserted";
                        this.Hide();
                        frm_login ln = new frm_login();
                        ln.Show();
                    }
                }
           

            con.Close();
        }
    }
}
