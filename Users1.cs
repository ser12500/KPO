using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kursach
{
    public partial class Users1 : Form
    {
        public Users1()
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
            string query = "select * from UserTb1";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds=new DataSet();
            da.Fill(ds);
            UserDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Id.Text == "" || Uname.Text == "" || Upass.Text == "")
            {

                MessageBox.Show("Недостающая информация");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Insert into UserTb1 values (" + Id.Text + ",'" + Uname.Text + "','" + Upass.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User успешно добавлен");
                    Con.Close();
                    populate();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void Users1_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Id.Text == "")
            {
                MessageBox.Show("Недостающая информация");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from UserTb1 where ID=" + Id.Text + ";";
                    SqlCommand cmd =new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User успешно удален");
                    Con.Close();
                    populate();


                }
                catch(Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id.Text = UserDGV.SelectedRows[0].Cells[0].Value.ToString();
            Uname.Text = UserDGV.SelectedRows[0].Cells[1].Value.ToString();
            Upass.Text = UserDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Id.Text == "" || Uname.Text == "" || Upass.Text == "")
            {

                MessageBox.Show("Недостающая информация");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update UserTb1 set Uname = '" + Uname.Text + "',Upass ='" + Upass.Text + "'where Id="+Id.Text+";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User успешно обновлен");
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
            MainForm main=new MainForm();
            main.Show();
        }
    }
}
