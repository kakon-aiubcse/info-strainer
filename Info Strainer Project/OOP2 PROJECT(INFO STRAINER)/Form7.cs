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
    public partial class Form7 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form7()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (txtPass.Text != "" && txtUser.Text != "")
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "insert into login_tbl_2 values (@user, @pass ,@email, @contact)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@user", txtUser.Text);
                cmd.Parameters.AddWithValue("@pass", txtPass.Text);
                cmd.Parameters.AddWithValue("@email", txtMail.Text);
                cmd.Parameters.AddWithValue("@contact", txtContact.Text);

                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Signup Successfull");

                }
                else
                {
                    MessageBox.Show("Signup failed");
                }

                Form3 F = new Form3();
                this.Hide();
                F.Show();
            }
            else
            {
                MessageBox.Show("Fill the Field", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
