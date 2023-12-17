using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kursach
{
    public partial class vuecars : Form
    {
        public vuecars()
        {
            InitializeComponent();
        }

        private void guna2TrackBar1_ValueChanged(object sender, EventArgs e)
        {

            label31.Text=guna2TrackBar1.Value.ToString()+ "$";
        }

        private void guna2TrackBar2_ValueChanged(object sender, EventArgs e)
        {
            year.Text=guna2TrackBar2.Value.ToString() ;
        }

        private void guna2TrackBar3_ValueChanged(object sender, EventArgs e)
        {
            km.Text=guna2TrackBar3.Value.ToString()+ "km";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            guna2PictureBox1car.Image=pictureBox1.Image;
            pictureBox7.Load("cars\\audi q8\\1.png");
            pictureBox8.Load("cars\\audi q8\\2.png");
            pictureBox9.Load("cars\\audi q8\\3.png");
            label30.Text=label11.Text;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            guna2PictureBox1car.Image = pictureBox7.Image;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            guna2PictureBox1car.Image = pictureBox8.Image;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            guna2PictureBox1car.Image = pictureBox9.Image;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            guna2PictureBox1car.Image = pictureBox2.Image;
            pictureBox7.Load("cars\\audi r 7\\1.png");
            pictureBox8.Load("cars\\audi r 7\\2.png");
            pictureBox9.Load("cars\\audi r 7\\3.png");
            label30.Text = label12.Text;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            guna2PictureBox1car.Image = pictureBox3.Image;
            pictureBox7.Load("cars\\bmv\\1.png");
            pictureBox8.Load("cars\\bmv\\2.png");
            pictureBox9.Load("cars\\bmv\\3.png");
            label30.Text = label13.Text;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            guna2PictureBox1car.Image = pictureBox4.Image;
            pictureBox7.Load("cars\\camaro\\1.png");
            pictureBox8.Load("cars\\camaro\\2.png");
            pictureBox9.Load("cars\\camaro\\3.png");
            label30.Text = label14.Text;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            guna2PictureBox1car.Image = pictureBox5.Image;
            pictureBox7.Load("cars\\mers\\1.png");
            pictureBox8.Load("cars\\mers\\2.png");
            pictureBox9.Load("cars\\mers\\3.png");
            label30.Text = label15.Text;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            guna2PictureBox1car.Image = pictureBox6.Image;
            pictureBox7.Load("cars\\bmv1\\1.png");
            pictureBox8.Load("cars\\bmv1\\2.png");
            pictureBox9.Load("cars\\bmv1\\3.png");
            label30.Text = label16.Text;
        }
    }
}
