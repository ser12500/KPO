using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace kursach
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();

        }
     
        
        private void button2_Click(object sender, EventArgs e)
        {
            log.Text = "";
            par.Text = "";
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kerge\OneDrive\Документы\car.mdf;Integrated Security=True;Connect Timeout=30");
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

        
    }
}
