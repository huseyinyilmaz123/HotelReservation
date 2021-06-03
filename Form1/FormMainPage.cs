using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class FormMainPage : Form
    {
        public FormMainPage()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormReservation freserv = new FormReservation();
            freserv.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();

        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.labelTime.Text = dateTime.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRooms fr = new FormRooms();
            fr.Show();
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormClients fc = new FormClients();
            fc.Show();
        }

        private void FormMainPage_Load(object sender, EventArgs e)
        {

        }
    }
}
