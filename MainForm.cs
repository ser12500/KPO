using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            if (!String.IsNullOrEmpty(Properties.Settings.Default.Language)) 
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo(Properties.Settings.Default.Language);
                System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo(Properties.Settings.Default.Language);
            }
            
            InitializeComponent();
            this.Load += comboBox1_Load;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Car car = new Car();
            car.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customers cas = new Customers();
            cas.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sales re = new Sales();
            re.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Car car = new Car();
            car.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users1 us = new Users1();
            us.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            vuecars car = new vuecars();
            car.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_Load(object sender, EventArgs e)
        {
            // Ваш код для обработки события Load
            comboBox1.DataSource = new System.Globalization.CultureInfo[] {
            System.Globalization.CultureInfo.GetCultureInfo("ru-RU"),
            System.Globalization.CultureInfo.GetCultureInfo("en-US")

            };
            comboBox1.DisplayMember = "Nativename";
            comboBox1.ValueMember = "Name";

            if (!String.IsNullOrEmpty(Properties.Settings.Default.Language)) 
            {
                comboBox1.SelectedValue = Properties.Settings.Default.Language;
            }

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Language = comboBox1.SelectedValue.ToString();
            Properties.Settings.Default.Save();
        }
    }

}   
    

