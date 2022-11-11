using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Configuration;
using System.Data.SqlClient;

namespace OOP2_PROJECT_INFO_STRAINER_
{


    public partial class Form8 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public string PrimaryKey { set; get; }
        public bool comingFromExpert { set; get; }
      

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr createRoundRectRgn
            (
            int nleftRect,
            int nTopReact,
            int nRightReact,
            int nBottomReact,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public Form8()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(createRoundRectRgn(0, 0, Width, Height, 7, 7));
            pnlNav.Height = btnQueries.Height;
            pnlNav.Top = btnQueries.Top;
            pnlNav.Left = btnQueries.Left;
            btnQueries.BackColor = Color.FromArgb(46, 51, 73);
        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            if(comingFromExpert == false)
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "select username from login_tbl_1 where username=@user";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@user", this.PrimaryKey);


                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    txtUsername.Text = PrimaryKey;
                }
            }
            else
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "select username from login_tbl_2 where username=@user";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@user", this.PrimaryKey);


                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    txtUsername.Text = PrimaryKey;
                }
            }
        }

        private void btnQueries_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnQueries.Height;
            pnlNav.Top = btnQueries.Top;
            pnlNav.Left = btnQueries.Left;
            btnQueries.BackColor = Color.FromArgb(46, 51, 73);

            loadform(new Form9_Queries_());
        }

        private void btnResearches_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnResearches.Height;
            pnlNav.Top = btnResearches.Top;
            btnResearches.BackColor = Color.FromArgb(46, 51, 73);

            loadform(new Form9__Researches_());
        }

        private void btnIssues_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnIssues.Height;
            pnlNav.Top = btnIssues.Top;
            btnIssues.BackColor = Color.FromArgb(46, 51, 73);

            loadform(new Form9__Issues_());
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnContact.Height;
            pnlNav.Top = btnContact.Top;
            btnContact.BackColor = Color.FromArgb(46, 51, 73);

            loadform(new Form9__Contact_());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSettings.Height;
            pnlNav.Top = btnSettings.Top;
            btnSettings.BackColor = Color.FromArgb(46, 51, 73);

            loadform(new Form9__Settings_());

        }

        private void btnQueries_Leave(object sender, EventArgs e)
        {
            btnQueries.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnResearches_Leave(object sender, EventArgs e)
        {
            btnResearches.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnIssues_Leave(object sender, EventArgs e)
        {
            btnIssues.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnContact_Leave(object sender, EventArgs e)
        {
            btnContact.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            this.Hide();
            F.Show();
        }
    }
}
