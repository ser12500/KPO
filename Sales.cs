using System;
using System.Collections;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace kursach
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\chhv\Documents\car.mdf;Integrated Security=True;Connect Timeout=30");
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void fillcombo()
        {
            Con.Open();
            string query = "select  RegNum from Car where Availabel='" + "Yes" + "' ";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RegNum", typeof(string));
            dt.Load(rdr);
            Carreg.ValueMember = "RegNum";
            Carreg.DataSource = dt;
            Con.Close();

        }
        private void fillcustomer()
        {
            Con.Open();
            string query = "select  CustId from CustomerTb1 ";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustId", typeof(int));
            dt.Load(rdr);
            CustId.ValueMember = "CustId";
            CustId.DataSource = dt;
            Con.Close();

        }
        private void Rental_Load(object sender, EventArgs e)
        {
            fillcombo();
            fillcustomer();
            populate();
        }

        private void fetchCustName()
        {
            Con.Open();
            string query = "select * from CustomerTb1 where CustId=" + CustId.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                name.Text = dr["CustName"].ToString();
            }
            Con.Close();
        }

        private void update()
        {
            Con.Open();
            string query = "update Car set Availabel='" + "No" + "', where RegNum =" + Carreg.SelectedValue.ToString() + ";";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Car успешно обновлен");
            Con.Close();

        }
        private void updateDEL()
        {
            Con.Open();
            string query = "update Car set Availabel='" + "Yes" + "', where RegNum =" + Carreg.SelectedValue.ToString() + ";";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Car успешно обновлен");
            Con.Close();



        }

        private void Carreg_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void CustId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchCustName();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from RentalTb1";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            SalesDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (id.Text == "" || name.Text == "" || fees.Text == "")
            {

                MessageBox.Show("Недостающая информация");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Insert into RentalTb1 values ('" + id.Text + "','" + Carreg.SelectedValue.ToString() + "','" + CustId.Text + "','" + Rentaldate.Text + "','" + fees.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car успешно добавлен");
                    Con.Close();
                    populate();
                    update();

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
                    string query = "delete from RentalTb1 where RenId=" + id.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("RenId успешно удален");
                    Con.Close();
                    populate();
                    updateDEL();


                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void SalesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = SalesDGV.SelectedRows[0].Cells[0].Value.ToString();
            Carreg.SelectedValue = SalesDGV.SelectedRows[0].Cells[1].Value.ToString();
            CustId.Text = SalesDGV.SelectedRows[0].Cells[3].Value.ToString();
            fees.Text = SalesDGV.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
