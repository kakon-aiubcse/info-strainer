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
using System.IO;


namespace OOP2_PROJECT_INFO_STRAINER_
{
    public partial class Form12_admin_ : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form12_admin_()
        {
            InitializeComponent();
            bindgridview_1();
            bindgridview_2();

        }


 
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUser.Text = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtPassword.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtEmail.Text = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtContact.Text = guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void Form12_admin__Load(object sender, EventArgs e)
        {

        }


        void bindgridview_1()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from login_tbl_2";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            guna2DataGridView1.DataSource = data;
            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            guna2DataGridView1.RowTemplate.Height = 30;
        }

        void bindgridview_2()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from login_tbl_1";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            guna2DataGridView2.DataSource = data;
            guna2DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            guna2DataGridView2.RowTemplate.Height = 30;
        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUser1.Text = guna2DataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            txtPassword1.Text = guna2DataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            txtEmail1.Text = guna2DataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            txtContact1.Text = guna2DataGridView2.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            resetcontrol_1();
        }
        private void resetcontrol_1()
        {
            txtUser1.Clear();
            txtPassword1.Clear();
            txtEmail1.Clear();
            txtContact1.Clear();

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            resetcontrol();
        }
        private void resetcontrol()
        {
            txtUser.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
            txtContact.Clear();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "update login_tbl_1 set username=@username,pass=@pass,email=@email,contact=@contact where username=@username";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", txtUser1.Text);
            cmd.Parameters.AddWithValue("@pass", txtPassword1.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail1.Text);
            cmd.Parameters.AddWithValue("@contact", txtContact1.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Updated Successfully");
                bindgridview_2();
            }
            else
            {
                MessageBox.Show("Update Failed! Can't Change User!");
            }
            resetcontrol_1();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into login_tbl_1 values (@username,@pass,@email,@contact)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", txtUser1.Text);
            cmd.Parameters.AddWithValue("@pass", txtPassword1.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail1.Text);
            cmd.Parameters.AddWithValue("@contact", txtContact1.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Inserted Successfully");
                bindgridview_2();
            }
            else
            {
                MessageBox.Show("Data Insertion failed");
            }
            resetcontrol_1();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into login_tbl_2 values (@username,@pass,@email,@contact)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", txtUser.Text);
            cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@contact", txtContact.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Inserted Successfully");
                bindgridview_1();
            }
            else
            {
                MessageBox.Show("Data Insertion failed");
            }
            resetcontrol();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "update login_tbl_2 set username=@username,pass=@pass,email=@email,contact=@contact where username=@username";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", txtUser.Text);
            cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@contact", txtContact.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Updated Successfully");
                bindgridview_1();
            }
            else
            {
                MessageBox.Show("Updated Failed! Can't Change User!");
            }
            resetcontrol();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "delete from login_tbl_1 where username=@username";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", txtUser1.Text);

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Deleted Successfully");
                bindgridview_2();

            }
            else
            {
                MessageBox.Show("Data Deletion failed");
            }
            resetcontrol();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "delete from login_tbl_2 where username=@username";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", txtUser.Text);

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Deleted Successfully");
                bindgridview_1();

            }
            else
            {
                MessageBox.Show("Data Deletion failed");
            }
            resetcontrol_1();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }
    }
}
