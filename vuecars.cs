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
            label30.Text = label15.Text;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            guna2PictureBox1car.Image = pictureBox4.Image;
            pictureBox7.Load("cars\\camaro\\1.png");
            pictureBox8.Load("cars\\camaro\\2.png");
            pictureBox9.Load("cars\\camaro\\3.png");
            label30.Text = label18.Text;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            guna2PictureBox1car.Image = pictureBox5.Image;
            pictureBox7.Load("cars\\mers\\1.png");
            pictureBox8.Load("cars\\mers\\2.png");
            pictureBox9.Load("cars\\mers\\3.png");
            label30.Text = label24.Text;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            guna2PictureBox1car.Image = pictureBox6.Image;
            pictureBox7.Load("cars\\bmv1\\1.png");
            pictureBox8.Load("cars\\bmv1\\2.png");
            pictureBox9.Load("cars\\bmv1\\3.png");
            label30.Text = label21.Text;
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            guna2PictureBox1car.Image = pictureBox15.Image;
         
            pictureBox8.Load("cars\\1\\2.png");
            pictureBox7.Load("cars\\1\\1.png");
            pictureBox9.Load("cars\\1\\3.png");
            label30.Text = label21.Text;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            guna2PictureBox1car.Image = pictureBox14.Image;
            pictureBox7.Load("cars\\2\\1.png");
            pictureBox8.Load("cars\\2\\2.png");
            pictureBox9.Load("cars\\2\\3.png");
            label30.Text = label21.Text;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            guna2PictureBox1car.Image = pictureBox13.Image;
            pictureBox7.Load("cars\\3\\1.png");
            pictureBox8.Load("cars\\3\\2.png");
            pictureBox9.Load("cars\\3\\3.png");
            label30.Text = label21.Text;

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            guna2PictureBox1car.Image = pictureBox12.Image;
            
            pictureBox8.Load("cars\\4\\2.png");
            pictureBox9.Load("cars\\4\\3.png");
            label30.Text = label21.Text;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            guna2PictureBox1car.Image = pictureBox11.Image;
            pictureBox7.Load("cars\\5\\1.png");
            pictureBox8.Load("cars\\5\\2.png");
            pictureBox9.Load("cars\\5\\3.png");
            label30.Text = label21.Text;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            guna2PictureBox1car.Image = pictureBox10.Image;
            pictureBox7.Load("cars\\6\\1.png");
            pictureBox8.Load("cars\\6\\2.png");
            pictureBox9.Load("cars\\6\\3.png");
            label30.Text = label21.Text;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }
    }
}
