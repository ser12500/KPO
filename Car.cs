using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace kursach
{
    [Serializable]
    public partial class Car : Form, ISerializable
    {
        public Car()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kerge\OneDrive\Документы\car.mdf;Integrated Security=True;Connect Timeout=30");
        public void label2_Click(object sender, EventArgs e)
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
        public void button1_Click(object sender, EventArgs e)
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

        public void Car_Load(object sender, EventArgs e)
        {
            populate();
        }

        public void button3_Click(object sender, EventArgs e)
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

        public void carsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Regnumc.Text = carsDGV.SelectedRows[0].Cells[0].Value.ToString();
            Brandc.Text = carsDGV.SelectedRows[0].Cells[1].Value.ToString();
            Modelc.Text = carsDGV.SelectedRows[0].Cells[2].Value.ToString();
            AvailableC.SelectedItem = carsDGV.SelectedRows[0].Cells[3].Value.ToString();
            Pricec.Text = carsDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        public void button2_Click(object sender, EventArgs e)
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
                    string query = "update Car set Brand = '" + Brandc.Text + "',Model ='" + Modelc.Text + "',Available='" + AvailableC.SelectedItem.ToString() + "',Price = '" + Pricec.Text + "' where RegNum =" + Regnumc.Text + ";";
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

        public void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Сериализация необходимых полей
            info.AddValue("RegNum", Regnumc.Text);
            info.AddValue("Brand", Brandc.Text);
            info.AddValue("Model", Modelc.Text);
            info.AddValue("Price", Pricec.Text);



        }
        protected Car(SerializationInfo info, StreamingContext context)
        {
            Regnumc.Text = info.GetString("RegNum");
            Brandc.Text = info.GetString("Brand");
            Modelc.Text = info.GetString("Model");
            Pricec.Text = info.GetString("Price");
        }


    
      

        private void SaveCarToFile(string filePath)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    formatter.Serialize(stream, this);
                }
                MessageBox.Show("Сериализация прошла успешно.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении: " + ex.Message);
            }

        }
        private void LoadCarFromFile(string filePath)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream stream = new FileStream(filePath, FileMode.Open))
                {
                    Car loadedCar = (Car)formatter.Deserialize(stream);

                    // Заменяем текущий объект Car загруженным объектом
                    Regnumc.Text = loadedCar.Regnumc.Text;
                    Brandc.Text = loadedCar.Brandc.Text;
                    Modelc.Text = loadedCar.Modelc.Text;
                    
                    Pricec.Text = loadedCar.Pricec.Text;

                    MessageBox.Show("Car успешно загружен из файла.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке: " + ex.Message);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            SaveCarToFile("car_data.dat");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadCarFromFile("car_data.dat");
        }
    }
}