using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace OOP2_PROJECT_INFO_STRAINER_
{
    public partial class Form11 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form11()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
             if(txtPassword.Text!="" && txtUsername.Text!="")
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "select * from admin_login_tbl where username=@user and pass=@pass";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@user",txtUsername.Text);
                cmd.Parameters.AddWithValue("@pass",txtPassword.Text);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    //MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form12_admin_ f = new Form12_admin_();
                    this.Hide();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                con.Close();
            }
            else
            {
                MessageBox.Show("Fill the Field", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            bool status = toggleCheck.Checked;
            switch(status)
            {
                case true:
                    txtPassword.UseSystemPasswordChar = false;
                    break;
                default:
                    txtPassword.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }
    }
}
