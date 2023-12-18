using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace kursach
{
    internal class CarTests
    {
        public bool MessageBoxShown { get; private set; }
        public bool MainFormOpened { get; private set; }


        [Test]

        public void TestAddCar()
        {
            // Arrange
            Car carForm = new Car();

            // Act
            carForm.Regnumc.Text = "123";
            carForm.Brandc.Text = "Toyota";
            carForm.Modelc.Text = "Camry";
            carForm.Pricec.Text = "25000";
         
            carForm.button1_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual(1, carForm.carsDGV.Rows.Count, "Тест добавления автомобиля провален"); // Проверка, что добавилась одна запись
        }

        [Test]
        public void TestDeleteCar()
        {
            // Arrange
            Car carForm = new Car();
            carForm.Regnumc.Text = "123";
            carForm.Brandc.Text = "Toyota";
            carForm.Modelc.Text = "Camry";
            carForm.Pricec.Text = "25000";
           
            carForm.button1_Click(null, EventArgs.Empty);

            // Act
            carForm.Regnumc.Text = "123";
            carForm.button3_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual(0, carForm.carsDGV.Rows.Count,"Тест добавления автомобиля провален"); // Проверка, что запись была удалена
        }

        [Test]
        public void TestUpdateCar()
        {
            // Arrange
            Car carForm = new Car();
            carForm.Regnumc.Text = "123";
            carForm.Brandc.Text = "Toyota";
            carForm.Modelc.Text = "Camry";
            carForm.Pricec.Text = "25000";
          
            carForm.button1_Click(null, EventArgs.Empty);

            // Act
            carForm.Regnumc.Text = "123";
            carForm.Brandc.Text = "Honda";
            carForm.Modelc.Text = "Accord";
            carForm.Pricec.Text = "30000";
         
            carForm.button2_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual("Honda", carForm.carsDGV.Rows[0].Cells[1].Value,"Тест добавления автомобиля провален"); // Проверка, что данные были обновлены
        }

    }
}
