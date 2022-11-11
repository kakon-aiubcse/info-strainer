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
    public partial class Form9__Researches_ : Form
    {
        public Form9__Researches_()
        {
            InitializeComponent();
        }
        int count = 0;
        int count_1 = 0;

        

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(count_1 < 6)
            {
                guna2PictureBox3.Image = imageList2.Images[count_1];
                count_1++;
            }
            else
            {
                count_1 = 0;
            }
        }
       
        

        private void Form9__Researches__Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (count_1 < 6)
            {
                guna2PictureBox2.Image = imageList3.Images[count_1];
                count_1++;
            }
            else
            {
                count_1 = 0;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (count_1 < 6)
            {
                guna2PictureBox4.Image = imageList4.Images[count_1];
                count_1++;
            }
            else
            {
                count_1 = 0;
            }
        }
    }
}
