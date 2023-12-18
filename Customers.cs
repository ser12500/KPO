using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\chhv\Documents\car.mdf;Integrated Security=True;Connect Timeout=30");
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from CustomerTb1";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            custDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (id.Text == "" || name.Text == "" || adress.Text == "" || phone.Text == "")
            {

                MessageBox.Show("Недостающая информация");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Insert into CustomerTb1 values ('" + id.Text + "','" + name.Text + "','" + adress.Text + "','" + phone.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("CustomerT успешно добавлен");
                    Con.Close();
                    populate();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void custDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = custDGV.SelectedRows[0].Cells[0].Value.ToString();
            name.Text = custDGV.SelectedRows[0].Cells[1].Value.ToString();
            adress.Text = custDGV.SelectedRows[0].Cells[2].Value.ToString();
            phone.Text = custDGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (id.Text == "")
            {
                MessageBox.Show("Недостающая информация");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from CustomerTb1 where Custid=" + id.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Custid успешно удален");
                    Con.Close();
                    populate();


                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (id.Text == "" || name.Text == "" || adress.Text == "" || phone.Text == "")
            {

                MessageBox.Show("Недостающая информация");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update CustomerTb1 set CustName = '" + name.Text + "',CustAdd ='" + adress.Text + "',Phone = '" + phone.Text + "' where Custid =" + id.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("CustomerTb1 успешно обновлен");
                    Con.Close();
                    populate();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }
    }
}
