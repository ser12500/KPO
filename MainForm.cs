using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Car car = new Car();
            car.Show();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customers cas = new Customers();
            cas.Show();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sales re = new Sales();
            re.Show();
        }

        public void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Car car = new Car();
            car.Show();
        }

        public void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users1 us = new Users1();
            us.Show();
        }

        public void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            vuecars car = new vuecars();
            car.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOGIN main = new LOGIN();
            main.Show();
        }
    }
    
}   
    

