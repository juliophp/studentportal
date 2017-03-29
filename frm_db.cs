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
    public partial class frm_db : Form
    {
        public frm_db(String stdname, String stdid)
        {
            InitializeComponent();
            id.Text = stdid;
            InfoTab.Visible = false;
        }

        private void viewCourses_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=adeyemi;Initial Catalog=studentportal;Integrated Security=True";
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from grades where student_id = @id and enrolled = 1";

            cmd.Parameters.AddWithValue("@id", id.Text);


            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            if(dr.HasRows)
            {

                SqlCommand cmdd = new SqlCommand();
                cmdd.Connection = con;
                InfoTab.Visible = true;
                cmdd.CommandText = "Select * from courses where student_id = @id and enrolled = 1";

            }
            else
            {
                res.Text = "You have not registered for any course";
                InfoTab.Visible = false;
                res.Visible = true;
            }
        }
    }
}
