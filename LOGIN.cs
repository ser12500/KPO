using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU");
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            log.Text = "";
            par.Text = "";
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\chhv\Documents\car.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select count(*) from UserTb1 where Uname='" + log.Text + "' and Upass='" + par.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query,Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString()== "1")
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Неправильный логин или пароль");
            }
            Con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Load(object sender, LayoutEventArgs e)
        {
        
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}
