using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2_PROJECT_INFO_STRAINER_
{
    public partial class Form9__Issues_ : Form
    {
        public Form9__Issues_()
        {
            InitializeComponent();
        }
        int count = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count < 6)
            {
                guna2PictureBox1.Image = imageList1.Images[count];
                count++;
            }
            else
            {
                count = 0;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (count < 6)
            {
                guna2PictureBox3.Image = imageList1.Images[count];
                count++;
            }
            else
            {
                count = 0;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (count < 6)
            {
                guna2PictureBox4.Image = imageList1.Images[count];
                count++;
            }
            else
            {
                count = 0;
            }
        }
    }
}
