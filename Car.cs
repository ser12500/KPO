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
using System.Xml.Linq;
using System.Data.SqlClient;

namespace kursach
{
    public partial class Car : Form
    {
        public Car()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kerge\OneDrive\Документы\car.mdf;Integrated Security=True;Connect Timeout=30");
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from Car";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            carsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Regnumc.Text == "" || Brandc.Text == "" || Modelc.Text == "" || Pricec.Text == "" )
            {

                MessageBox.Show("Недостающая информация");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Insert into Car values ('" + Regnumc.Text + "','" + Brandc.Text + "','" + Modelc.Text + "','" + AvailableC.SelectedItem.ToString() + "','" + Pricec.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car успешно добавлен");
                    Con.Close();
                    populate();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void Car_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Regnumc.Text == "")
            {
                MessageBox.Show("Недостающая информация");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from Car where RegNum=" + Regnumc.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car успешно удален");
                    Con.Close();
                    populate();


                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void carsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Regnumc.Text = carsDGV.SelectedRows[0].Cells[0].Value.ToString();
            Brandc.Text = carsDGV.SelectedRows[0].Cells[1].Value.ToString();
            Modelc.Text = carsDGV.SelectedRows[0].Cells[2].Value.ToString();
            AvailableC.SelectedItem = carsDGV.SelectedRows[0].Cells[3].Value.ToString();
            Pricec.Text = carsDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Regnumc.Text == "" || Brandc.Text == "" || Modelc.Text == "" || Pricec.Text == "")
            {

                MessageBox.Show("Недостающая информация");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update Car set Brand = '" + Brandc.Text + "',Model ='" + Modelc.Text + "',Available='"+ AvailableC.SelectedItem.ToString() + "',Price = '"+Pricec.Text+"' where RegNum =" + Regnumc.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car успешно обновлен");
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
    }
}
