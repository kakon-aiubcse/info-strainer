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
    public partial class Form3 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Form5 F = new Form5();
            this.Hide();
            F.Show();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

            if (txtPass.Text != "" && txtUser.Text != "")
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "select username, pass from login_tbl_2 where username=@user and pass=@pass";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@user", txtUser.Text);
                cmd.Parameters.AddWithValue("@pass", txtPass.Text);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    //MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form10 f = new Form10();
                    f.PrimaryKey = txtUser.Text;
                    f.comingFromExpert = true;
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
            switch (status)
            {
                case true:
                    txtPass.UseSystemPasswordChar = false;
                    break;
                default:
                    txtPass.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }
    }
}
