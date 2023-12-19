using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using kursach.Properties;

namespace kursach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU");
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");
            InitializeComponent();

        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            myprogress.Value = startpoint;
            Percentage.Text =  startpoint+"%";
            if (myprogress.Value == 10 )
            { 
            myprogress.Value = 0;
                timer1.Stop();
                LOGIN log=new LOGIN();
                log.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
